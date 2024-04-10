using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mono.TextTemplating;
using PubHubWebServer.Data;
using PubHubWebServer.Data.Models;
using PubHubWebServer.Data.Models.Relationships;


//using YamlDotNet.Core.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PubHubWebServer.Services
{
    public class PubHubServices : IPubHubServices
    {
        private readonly PubHubDBContext pubHubDBContext;
        private readonly ILogger logger; //TODO: Create Custom logger
        public PubHubServices(PubHubDBContext _dBContext)
        {
            pubHubDBContext = _dBContext;
        }

        #region Generic EndPoints

        /// <summary>
        /// Adds a single entity to the database
        /// </summary>
        /// <typeparam name="T">The type of the entity</typeparam>
        /// <param name="_entity">The entity object</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> AddSingleEntity<T>(T _entity)
        {
            try
            {
                if (_entity == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "Entity was null"
                    };
                }
                await pubHubDBContext.AddAsync(_entity);
                pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to add entity: {_entity}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log

                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error adding entity"
                };
            }
        }

        /// <summary>
        /// Adds multiple entities to the database
        /// </summary>
        /// <typeparam name="T">The type that is to be added should be of the type <see cref="List{T}"/> where T is the type</typeparam>
        /// <param name="_entities">The List of entities that should be added</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> AddMultipleEntities<T>(T _entities)
        {
            try
            {
                if (_entities == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "Entities was null"
                    };
                }
                await pubHubDBContext.AddRangeAsync(_entities);
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to add entiies: {_entities}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error adding entities"
                };
            }
        }

        /// <summary>
        /// Updates a single entity
        /// </summary>
        /// <typeparam name="T">The Type of the entity that should be added</typeparam>
        /// <param name="_entity">The entity object</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> UpdateEntity<T>(T _entity)
        {
            try
            {
                if (_entity == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "Entity was null"
                    };
                }
                pubHubDBContext.Update(_entity);
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to update entity: {_entity}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while trying to update enitity"
                };
            }
        }

        /// <summary>
        /// Updates multiple entities
        /// </summary>
        /// <typeparam name="T">The type that is to be added should be of the type <see cref="List{T}"/> where T is the type</typeparam>
        /// <param name="_entities">The List of entities that should be added</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> UpdateMultipleEntities<T>(T _entities)
        {
            try
            {
                if (_entities == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "Entities was null"
                    };
                }
                pubHubDBContext.UpdateRange(_entities);
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to Update entiries: {_entities}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error updating entities"
                };
            }
        }

        /// <summary>
        /// Retrives a single entity 
        /// </summary>
        /// <typeparam name="T">The type of the entity</typeparam>
        /// <param name="_entity">The entity object</param>
        /// <returns></returns>
        public async Task<ApiResponse<T>> GetEntityByID<T>(Guid _entityID)
        {
            try
            {
                return new ApiResponse<T>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = (T)await pubHubDBContext.FindAsync(_entityID.GetType(), _entityID)
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get entiry by ID: {_entityID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _entityID);//Save log
                return new ApiResponse<T>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting entity"
                };
            }
        }

        /// <summary>
        /// Retrives multiple entities
        /// </summary>
        /// <typeparam name="T">The type that is to be retived, should be of the type <see cref="List{T}"/> where T is the type</typeparam>
        /// <param name="_entities">The List of entities that should be added</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<T>>> GetMultipleEntitiesByIDs<T>(List<Guid> _entities)
        {
            try
            {
                List<T> entities = new();
                foreach (Guid entity in _entities)
                {
                    entities.Add((T)await pubHubDBContext.FindAsync(entity.GetType(), entity));
                }

                return new ApiResponse<List<T>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = entities,
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<List<T>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting entity"
                };
            }
        }

        /// <summary>
        /// Deletes a single entity 
        /// </summary>
        /// <typeparam name="T">The type of the entity</typeparam>
        /// <param name="_entity">The entity object</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> DeleteEntity<T>(T _entity)
        {
            try
            {
                if (_entity == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "Entity was null"
                    };
                }
                pubHubDBContext.Remove(_entity);
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to delete entiry: {_entity}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error deleting entity"
                };
            }
        }

        /// <summary>
        /// Deletes multiple entities
        /// </summary>
        /// <typeparam name="T">The type that is to be Deleted, should be of the type <see cref="List{T}"/> where T is the type</typeparam>
        /// <param name="_entities">The List of entities that should be added</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> DeleteMultipleEntities<T>(T _entities)
        {
            try
            {
                if (_entities == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "Entity was null"
                    };
                }
                pubHubDBContext.RemoveRange(_entities);
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.BadRequest,
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to delete entities {_entities}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error deleting entities"
                };
            }
        }

        #endregion

        #region User Endpoints

        /// <summary>
        /// finds the users role 
        /// </summary>
        /// <param name="_userID">The user in question</param>
        /// <returns></returns>
        public async Task<ApiResponse<IdentityRole>> GetUserRoles(string _userID)
        {
            try
            {
                if (_userID == null)
                {
                    return new ApiResponse<IdentityRole>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "UserID was null"
                    };
                }
                return new ApiResponse<IdentityRole>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = await pubHubDBContext.Roles.FindAsync(await pubHubDBContext.Users.Where(u => u.Id == _userID).FirstAsync())
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get user roles on userID: {_userID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, Guid.Parse(_userID));//Save log
                return new ApiResponse<IdentityRole>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error getting user roles"
                };
            }
        }

        /// <summary>
        /// Deactivates a user
        /// </summary>
        /// <param name="_userID">The user that shoud be deactived</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> DeactivateUser(string _userID)
        {
            try
            {
                if (_userID == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = "UserID was null"
                    };
                }
                ApplicationUser tempUser = await pubHubDBContext.Users.FindAsync(_userID);
                tempUser.Active = false;
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK,
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to Deactivate userID:{_userID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, Guid.Parse(_userID));//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error deactivating user"
                };
            }
        }

        #endregion

        #region Publisher Endpoints

        /// <summary>
        /// Finds all subscriptions on a publisher
        /// </summary>
        /// <param name="_publisherID">The publisher that should be looked up</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubSubscription>>> GetAllPublishersSubscriptions(Guid _publisherID)
        {
            try
            {
                PubHubPublisher publisher = await pubHubDBContext.Publishers.Include(p => p.Subscriptions).ThenInclude(sp => sp.PubHubSubscriptionSubscriptionID).FirstAsync(p => p.PublisherID == _publisherID);
                if (publisher == null)
                {
                    return new ApiResponse<List<PubHubSubscription>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Publisher not found"
                    };
                }
                List<PubHubSubscription> subscriptions = new();
                foreach (PubHubSupscriptionPubHubPublisher subscription in publisher.Subscriptions)
                {
                    subscriptions.Add(await pubHubDBContext.Subscriptions.Where(s => s.SubscriptionID == subscription.ID).FirstAsync());
                }

                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = subscriptions,
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get all subscriptions on publisherID: {_publisherID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _publisherID);//Save log
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error getting publishers subscriptions"
                };
            }
        }

        /// <summary>
        /// finds all the books a publisher have
        /// </summary>
        /// <param name="_PublisherID">The publisher to be looked at</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubEBook>>> GetAllPublishersBooks(Guid _PublisherID)
        {
            try
            {
                PubHubPublisher publisher = await pubHubDBContext.Publishers.Include(p => p.EBooks).ThenInclude(sp => sp.PubHubEBookEBookID).FirstAsync(p => p.PublisherID == _PublisherID);
                if (publisher == null)
                {
                    return new ApiResponse<List<PubHubEBook>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Publisher not found"
                    };
                }

                List<PubHubEBook> eBooks = new();
                foreach (PubHubEBookPubHubPublisher item in publisher.EBooks)
                {
                    eBooks.Add(pubHubDBContext.EBooks.Where(x => x.EBookID == item.PubHubEBookEBookID).First());
                }

                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = eBooks,
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Publisher books on publisherID: {_PublisherID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _PublisherID);//Save log
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error getting publishers books"
                };
            }
        }

        /// <summary>
        /// Finds the total eranings of a given user
        /// </summary>
        /// <param name="_userID">The user tha should be looked up</param>
        /// <returns></returns>
        public async Task<ApiResponse<double>> GetTotalEarnings(Guid _userID)
        {
            try
            {
                double total = await pubHubDBContext.Receipts.Where(r => r.EntityID == _userID).SumAsync(r => r.Price);
                if (total == null)
                {
                    return new ApiResponse<double>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "total not found"
                    };
                }
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = total
                };
            }
            catch (Exception ex)
            {

                string message = $"Failed to get total eranings on the user: {_userID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _userID);//Save log
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error getting publishers books"
                };
            }
        }

        #endregion

        #region Reader Endpoints

        public async Task<ApiResponse<List<PubHubSubscription>>> GetAllReadersSubscriptions(Guid _readerID)
        {
            try
            {
                PubHubReader reader = await pubHubDBContext.Readers.Include(p => p.Subscriptions).ThenInclude(sp => sp.PubHubSubscriptionSubscriptionID).FirstAsync(p => p.ReaderID == _readerID);
                if (reader == null)
                {
                    return new ApiResponse<List<PubHubSubscription>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Reader not found"
                    };
                }
                List<Guid> subscriptionReaders = reader.Subscriptions.Where(sr => sr.PubHubReaderReaderID == _readerID).Select(s => s.PubHubSubscriptionSubscriptionID).ToList();
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = GetMultipleEntitiesByIDs<PubHubSubscription>(subscriptionReaders).Result.Data,
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Reader Subscription on ReaderID: {_readerID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all subscriptions from reader"
                };
            }
        }

        /// <summary>
        /// Finds all books that a user have bought and have the right to download
        /// </summary>
        /// <param name="_readerID">The GUID of the reader that should be looked up</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubEBook>>> GetAllReadersBooks(Guid _readerID)
        {
            try
            {
                PubHubReader reader = await pubHubDBContext.Readers.Include(p => p.Subscriptions).ThenInclude(sp => sp.PubHubSubscriptionSubscriptionID).FirstAsync(p => p.ReaderID == _readerID);
                if (reader == null)
                {
                    return new ApiResponse<List<PubHubEBook>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Reader not found"
                    };
                }

                List<PubHubEBook> eBooks = new();
                foreach (PubHubEBookPubHubReader item in reader.EBooks)
                {
                    eBooks.Add(pubHubDBContext.EBooks.Where(x => x.EBookID == item.PubHubEBookEBookID).First());
                }

                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = eBooks
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Book on a ReaderID: {_readerID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _readerID);//Save log
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all Ebooks from reader"
                };
            }
        }

        /// <summary>
        /// Figures out how much a user have spendt 
        /// </summary>
        /// <param name="_userID">The user that should be looked up</param>
        /// <returns></returns>
        public async Task<ApiResponse<double>> GetTotalSpendings(Guid _userID)
        {
            //TODO: Do later
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception e)
            {

                throw;
            }
        }

        #endregion

        #region Subscription Endpoints

        /// <summary>
        /// Add a Ebook to the subscription 
        /// </summary>
        /// <param name="_bookID">The EbookID of the book that should be added</param>
        /// <param name="_subscriptionID">The ID of the subscription that the EBook should be added to</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> AddBookToSubscription(Guid _bookID, Guid _subscriptionID)
        {
            try
            {
                // Find the subscription by ID
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                if (subscription == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Subscription not found"
                    };
                }

                // Find the book by ID
                PubHubEBook book = await pubHubDBContext.EBooks.FindAsync(_bookID);
                if (book == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Book not found"
                    };
                }

                // Create a new entry in the join table
                var joinEntry = new PubHubEBookPubHubSubscription
                {
                    PubHubEBookEBookID = book.EBookID,
                    PubHubSubscriptionSubscriptionID = subscription.SubscriptionID
                };

                // Add the join entry to the context
                pubHubDBContext.EBookSubscriptions.Add(joinEntry);

                // Save changes to the database
                await pubHubDBContext.SaveChangesAsync();

                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to add bookid: {_bookID} to subscriptionID: {_subscriptionID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _subscriptionID);//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to add book to subscription"
                };
            }
        }

        /// <summary>
        /// Removes a book from a subscription
        /// </summary>
        /// <param name="_bookID">The EBookID of the book that should be removed</param>
        /// <param name="_subscriptionID">The subscriptionID that should have a book removed from it</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> RemoveBookFromSubscription(Guid _bookID, Guid _subscriptionID)
        {
            try
            {
                // Find the subscription by ID
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                if (subscription == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Subscription not found"
                    };
                }

                // Find the book by ID
                PubHubEBook book = await pubHubDBContext.EBooks.FindAsync(_bookID);
                if (book == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Book not found"
                    };
                }

                // Find the corresponding entry in the join table
                var joinEntry = await pubHubDBContext.EBookSubscriptions
                    .FirstOrDefaultAsync(es => es.PubHubEBookEBookID == _bookID && es.PubHubSubscriptionSubscriptionID == _subscriptionID);

                if (joinEntry != null)
                {
                    // Remove the join entry from the context
                    pubHubDBContext.EBookSubscriptions.Remove(joinEntry);

                    // Save changes to the database
                    await pubHubDBContext.SaveChangesAsync();
                }

                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to remove bookID: {_bookID} from subscriptionID: {_subscriptionID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to remove book from subscription"
                };
            }
        }

        /// <summary>
        /// Gets all the books on a given subscription
        /// </summary>
        /// <param name="_subscriptionID">The subscriptonID of the subscription that should retrive all books</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubEBook>>> GetAllBooksFromSubscription(Guid _subscriptionID)
        {
            try
            {
                // Find the subscription by ID
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                if (subscription == null)
                {
                    return new ApiResponse<List<PubHubEBook>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Subscription not found"
                    };
                }

                // Query the join table to get all books associated with the subscription
                var bookIDs = await pubHubDBContext.EBookSubscriptions
                    .Where(es => es.PubHubSubscriptionSubscriptionID == _subscriptionID)
                    .Select(es => es.PubHubEBookEBookID)
                    .ToListAsync();

                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = GetMultipleEntitiesByIDs<PubHubEBook>(bookIDs).Result.Data
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Book on the given subscriptionID:{_subscriptionID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all books from subscription"
                };
            }
        }

        /// <summary>
        /// Getting the total earnings from a single subscription
        /// </summary>
        /// <param name="_subscriptionID">The subscription ID that should be looked up</param>
        /// <returns>The total amount as a double</returns>
        public async Task<ApiResponse<double>> GetTotalErningsFromSubscription(Guid _subscriptionID)
        {
            try
            {
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = pubHubDBContext.Receipts.Where(x => x.Acquired == _subscriptionID).Sum(y => y.Price)
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Total Earnings with a subscriptionID: {_subscriptionID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _subscriptionID);//Save log
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting Total Earnings subscription. Message" + ex.Message
                };
            }
        }

        /// <summary>
        /// Get the top X subscriptions
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubSubscription>>> GetTopSubscriptions(int _amount, Guid? _publiser = null)
        {
            try
            {
                List<PubHubSubscription> subscriptions = pubHubDBContext.Subscriptions
                    .Include(p => p.Publisher
                        .Where(x => x.PubHubPublisherPublisherID == _publiser))
                    .Include(r => r.Reader
                        .GroupBy(q => q.PubHubSubscriptionSubscriptionID)
                        .OrderByDescending(gp => gp.Count())
                        .Take(_amount)
                        .Select(g => g.Key))
                    .Include(b => b.EBooks)
                    .ToList();

                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = subscriptions
                };
            }
            catch (Exception ex)
            {
                string message = "Failed to get Top subscriptions, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting top subscription. Message" + ex.Message
                };
            }
        }

        /// <summary>
        /// find the filtered subscription based on the paremetors
        /// </summary>
        /// <param name="startDate">From when should it start to look</param>
        /// <param name="endDate">To where should it look</param>
        /// <param name="_title">The title of the subscription</param>
        /// <param name="_skip">The skip amount</param>
        /// <param name="_take">The take amount</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubSubscription>>> GetSubscriptionByFilter(DateTime startDate, DateTime endDate, string _title = "", int _skip = 0, int _take = 10)
        {
            try
            {
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = pubHubDBContext.Subscriptions.Where(x => x.Title.Contains(_title)
                    && x.StartDate <= startDate
                    && x.EndDate >= endDate)
                    .Skip(_skip * _take)
                    .Take(_take)
                    .ToList()
                };
            }
            catch (Exception ex)
            {
                //string message = $"Failed to get books from filter with the following {_title}, {_author}, {_genre}, {_skip}, {_take}, with the following Error message: " + ex.Message;
                //SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting books on user"
                };
            }
        }

        #endregion

        #region Ebook Endpoints

        /// <summary>
        /// Finds all the books ona given user
        /// </summary>
        /// <param name="_userID">The ID of the user that should be looked up</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubEBook>>> GetAllBooksFromUserByID(string _userID)
        {
            //TODO: Fix
            throw new NotImplementedException();
            try
            {
                PubHubReader reader = await pubHubDBContext.Readers.Include(p => p.EBooks).ThenInclude(sp => sp.PubHubEBookEBookID).FirstAsync(p => p.ReaderID == Guid.Parse(_userID));
                if (reader == null)
                {
                    return new ApiResponse<List<PubHubEBook>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Publisher not found"
                    };
                }

                List<PubHubEBook> eBooks = new();
                foreach (PubHubEBookPubHubReader item in reader.EBooks)
                {
                    eBooks.Add(pubHubDBContext.EBooks.Where(x => x.EBookID == item.PubHubEBookEBookID).First());
                }

                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = eBooks
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get books from a user with ID:{_userID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, Guid.Parse(_userID));//Save log
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting books on user"
                };
            }
        }

        /// <summary>
        /// Gets all the earnigns on a given book id
        /// </summary>
        /// <param name="_bookID">The bookID that should be looked at</param>
        /// <returns>The total amount earned to that book</returns>
        public async Task<ApiResponse<double>> GetAllEarningsFromBookByID(Guid _bookID)
        {
            try
            {
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.OK,
                    //Finds the total amount of earnings from a single book
                    Data = pubHubDBContext.Receipts.Where(book => book.Acquired == _bookID).Sum(x => x.Price),
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Earnings with the given bookID: {_bookID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _bookID);//Save log
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting earnings"
                };
            }
        }

        /// <summary>
        /// Gets the top 10 books with the most download count
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubEBook>>> GetTopBooks(int _amount, Guid? _publisher = null)
        {
            try
            {
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    //Finds the books
                    Data = pubHubDBContext.EBooks
                    .Include(x => x.Publishers.Where(x => x.PubHubPublisherPublisherID == _publisher))
                    .OrderByDescending(d => d.DownloadCount)
                    .Take(_amount)
                    .ToList()
                };
            }
            catch (Exception ex)
            {
                string message = "Failed to get top books, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting top books"
                };
            }
        }

        /// <summary>
        /// Selects all Books that match the parametors
        /// </summary>
        /// <param name="_title">The title that should be looked up</param>
        /// <param name="_author">The authors that should be looked up</param>
        /// <param name="_genre">The genre that should be looked up</param>
        /// <param name="_skip">The amount that should be skiped</param>
        /// <param name="_take">The amount tha should be taken</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubEBook>>> GetBooksByFilter(string _title = "", string _author = "", string _genre = "", int _skip = 0, int _take = 10)
        {
            try
            {
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = pubHubDBContext.EBooks.Where(x => x.Title.Contains(_title)
                    && x.AuthorNames.Contains(_author)
                    && x.Genre.Contains(_genre))
                    .Skip(_skip * _take)
                    .Take(_take)
                    .ToList()
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get books from filter with the following {_title}, {_author}, {_genre}, {_skip}, {_take}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting books on user"
                };
            }
        }

        /// <summary>
        /// Adds a book to the readers subscription list
        /// </summary>
        /// <param name="_reader">The reader that should have a book added</param>
        /// <param name="_newsubscription">The subscription that hold the information</param>
        /// <param name="_RentedBoks">The list of books that should be added to the readers subscription list</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> ReaderRentBook(Guid _reader, PubHubSubscription _newsubscription, List<PubHubEBook> _RentedBoks)
        {
            try
            {
                PubHubSubscription newSubscrition = new() 
                {
                    Active = true,
                    EndDate = DateTime.MaxValue,
                    Message = _newsubscription.Message,
                    StartDate = DateTime.Now,
                    Price = _newsubscription.Price,
                    Title = _newsubscription.Title
                };
                //Added the subscription to the context
                pubHubDBContext.Subscriptions.Add(newSubscrition);

                //Added the relations between the reader and the subscription
                PubHubSubscriptionPubHubReader ReaderSubscription = new()
                {
                    PubHubReaderReaderID = _reader,
                    PubHubSubscriptionSubscriptionID = newSubscrition.SubscriptionID
                };
                AddSingleEntity(ReaderSubscription);

                //Create the table between the book and the subscription.
                foreach (PubHubEBook Book in _RentedBoks)
                {
                    PubHubEBookPubHubSubscription BookSub = new()
                    {
                        PubHubEBookEBookID = Book.EBookID,
                        PubHubSubscriptionSubscriptionID = newSubscrition.SubscriptionID
                    };

                    AddSingleEntity(BookSub);
                }

                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to add subscription to reader: {_reader}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log

                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error adding entity"
                };
            }
        }

        /// <summary>
        /// Adds a book to the readers list of owned books
        /// </summary>
        /// <param name="_readerID">The reader that should have a book added</param>
        /// <param name="_bookID">The book that should be added</param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> ReaderBuyBook(Guid _readerID, Guid _bookID)
        {
            try
            {
                //Makes the object need the database
                PubHubEBookPubHubReader EbookREader = new()
                { 
                    PubHubEBookEBookID = _bookID,
                    PubHubReaderReaderID = _readerID
                };

                //Leaves the rest to Addsingle entity
                AddSingleEntity(EbookREader);

                //Responce
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to nuy book: {_bookID} to Reader: {_readerID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log

                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error adding entity"
                };
            }
        }

        #endregion

        #region Logs Endpoints
        /// <summary>
        /// Gets a single log
        /// </summary>
        /// <param name="_logID">The log that should be rerived</param>
        /// <returns></returns>
        public async Task<ApiResponse<PubHubLog>> GetLogByID(Guid _logID)
        {
            try
            {
                PubHubLog log = await pubHubDBContext.Logs.Where(l => l.EntityID == _logID).FirstAsync();
                if (log == null)
                {
                    return new ApiResponse<PubHubLog>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "log not found"
                    };
                }
                return new ApiResponse<PubHubLog>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = log
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Log with the following ID: {_logID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _logID);//Save log
                return new ApiResponse<PubHubLog>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get log"
                };
            }
        }

        /// <summary>
        /// Gets all logs
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubLog>>> GetAllLogs()
        {
            try
            {
                List<PubHubLog> logs = await pubHubDBContext.Logs.ToListAsync();
                if (logs == null)
                {
                    return new ApiResponse<List<PubHubLog>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "logs not found"
                    };
                }
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = logs
                };
            }
            catch (Exception ex)
            {
                string message = "Failed to get Logs, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all logs"
                };
            }
        }

        /// <summary>
        /// Finds all logs that is related to a specefik entity
        /// </summary>
        /// <param name="_EntityID">The entity that should be looked up</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubLog>>> GetAllLogsOnEntityByID(Guid _EntityID)
        {
            try
            {
                List<PubHubLog> logs = await pubHubDBContext.Logs.Where(l => l.EntityID == _EntityID).ToListAsync();
                if (logs == null)
                {
                    return new ApiResponse<List<PubHubLog>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "logs not found"
                    };
                }
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = logs
                };
            }
            catch (Exception ex)
            {
                string message = $"Failed to get Logs on a the given EntiryID: {_EntityID}, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error, _EntityID);//Save log
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all logs from entity"
                };
            }
        }

        /// <summary>
        /// Looks though all logs and finds all that have the word "acquired" within its message
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<PubHubLog>>> GetAllLogsForAcquired()
        {
            try
            {
                List<PubHubLog> logs = await pubHubDBContext.Logs.Where(l => l.Message.ToUpper().Contains("ACQUIRED")).ToListAsync();
                if (logs == null)
                {
                    return new ApiResponse<List<PubHubLog>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "logs not found"
                    };
                }
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = logs
                };
            }
            catch (Exception ex)
            {
                string message = "Failed to get Logs, with the following Error message: " + ex.Message;
                SaveLog(message, LogType.Error);//Save log
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all logs for acquired"
                };
            }
        }

        #endregion

        #region Receipt Endpoints

        /// <summary>
        /// finds the newest instance of a receipt on a user
        /// </summary>
        /// <param name="_userID">The user that is to be looked up</param>
        /// <returns></returns>
        public async Task<ApiResponse<PubHubReceipt>> GetNewestReceiptFromUser(Guid _userID)
        {
            try
            {
                PubHubReceipt receipt = await pubHubDBContext.Receipts.Where(r => r.EntityID == _userID).OrderByDescending(r => r.TimeStamp).FirstAsync();
                if (receipt == null)
                {
                    return new ApiResponse<PubHubReceipt>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Receipt not found"
                    };
                }
                return new ApiResponse<PubHubReceipt>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = receipt
                };
            }
            catch (Exception ex)
            {
                string message = $"{_userID} tryed to get a receipt information but got the following error message: " + ex.Message;
                SaveLog(message, LogType.Error, _userID);//Save log
                return new ApiResponse<PubHubReceipt>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get newest receipt fron user"
                };
            }
        }

        /// <summary>
        /// Figures out how mush is earned on a single item
        /// </summary>
        /// <param name="_userID"></param>
        /// <returns></returns>
        public async Task<ApiResponse<double>> GetTotalFromAcquired(Guid _userID)
        {
            try
            {
                double total = await pubHubDBContext.Receipts.Where(r => r.Acquired == _userID).SumAsync(r => r.Price);
                if (total == null)
                {
                    return new ApiResponse<double>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "total not found"
                    };
                }
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = total
                };
            }
            catch (Exception ex)
            {
                string message = $"Tryed to get total on: {_userID} , but got following error message: " + ex.Message;
                SaveLog(message, LogType.Error, _userID);//Save the log
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get total from acquired"
                };
            }
        }

        #endregion

        #region Other

        /// <summary>
        /// Saves a log to the database
        /// </summary>
        /// <param name="_message">What did it do</param>
        /// <param name="_logType">How severe is the insident</param>
        /// <param name="_EntiryID">Who did something of note</param>
        /// <returns></returns>
        private async Task SaveLog(string _message, LogType _logType = LogType.Information, Guid? _EntiryID = null)
        {
            PubHubLog log = new()
            {
                EntityID = (_EntiryID != null) ? _EntiryID : null,
                LogType = _logType,
                TimeStamp = DateTime.UtcNow,
                Message = _message
            };
            AddSingleEntity<PubHubLog>(log);
        }

        /// <summary>
        /// Save a single receipt to the database
        /// </summary>
        /// <param name="_Entiry">Who got it </param>
        /// <param name="_Acquired">What did they get</param>
        /// <param name="_price">How much did they pay for it</param>
        /// <returns></returns>
        private async Task SaveReceipt(Guid _Entiry, Guid _Acquired, double _price)
        {
            PubHubReceipt receipt = new()
            {
                EntityID = _Entiry,
                Acquired = _Acquired,
                Price = _price,
                TimeStamp = DateTime.UtcNow,
            };
            AddSingleEntity<PubHubReceipt>(receipt);

        }

        public async Task<ApiResponse<bool>> AnyUsersInDB()
        {
            try
            {
                if (await pubHubDBContext.Users.CountAsync() > 0)
                {
                    return new ApiResponse<bool>
                    {
                        StatusCode = HttpStatusCode.OK,
                        Data = true,
                    };
                }

                return new ApiResponse<bool>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = false,
                    ErrorMessage = "No users in DB"
                };
            }
            catch (Exception ex)
            {
                return new ApiResponse<bool>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to check for users in DB"
                };
            }
        }

        #endregion
    }
}