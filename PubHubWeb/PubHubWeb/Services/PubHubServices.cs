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
using PubHubWeb.Data;
using PubHubWeb.Data.Models;
//using YamlDotNet.Core.Tokens;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PubHubWeb.Services
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
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error adding entity"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error adding entities"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode= HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while trying to update enitity"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error updating entities"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<T>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error while getting entity"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error deleting entity"
                };
            }
        }

        public async Task<ApiResponse<string>> DeleteMultipleEntities<T>(T _entity)
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
                pubHubDBContext.RemoveRange(_entity);
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.BadRequest,
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error deleting entities"
                };
            }
        }

        #endregion

        #region User Endpoints

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
                //TODO: Add logger
                return new ApiResponse<IdentityRole>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error getting user roles"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error deactivating user"
                };
            }
        }

        #endregion

        #region Publisher Endpoints

        public async Task<ApiResponse<List<PubHubSubscription>>> GetAllPublishersSubscriptions(Guid _readerID)
        {
            try
            {
                PubHubPublisher publisher = await pubHubDBContext.Publishers.FindAsync(_readerID);
                if (publisher == null)
                {
                    return new ApiResponse<List<PubHubSubscription>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Publisher not found"
                    };
                }
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = publisher.Subscriptions
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error getting publishers subscriptions"
                };
            }
        }

        public async Task<ApiResponse<List<PubHubEBook>>> GetAllPublishersBooks(Guid _readerID)
        {
            try
            {
                PubHubPublisher publisher = await pubHubDBContext.Publishers.FindAsync(_readerID);
                if (publisher == null)
                {
                    return new ApiResponse<List<PubHubEBook>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Publisher not found"
                    };
                }
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = publisher.EBooks.ToList()
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Error getting publishers books"
                };
            }
        }

        public async Task<ApiResponse<double>> GetTotalEarnings(Guid _userID)
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

        #region Reader Endpoints

        public async Task<ApiResponse<List<PubHubSubscription>>> GetAllReadersSubscriptions(Guid _readerID)
        {
            try
            {
                PubHubReader reader = await pubHubDBContext.Readers.FindAsync(_readerID);
                if (reader == null)
                {
                    return new ApiResponse<List<PubHubSubscription>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Reader not found"
                    };
                }
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = reader.Subscriptions.ToList()
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<List<PubHubSubscription>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all subscriptions from reader"
                };
            }
        }

        public async Task<ApiResponse<List<PubHubEBook>>> GetAllReadersBooks(Guid _readerID)
        {
            try
            {
                PubHubReader reader = await pubHubDBContext.Readers.FindAsync(_readerID);
                if (reader == null)
                {
                    return new ApiResponse<List<PubHubEBook>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Reader not found"
                    };
                }
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = reader.EBooks.ToList()
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all Ebooks from reader"
                };
            }
        }

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

        public async Task<ApiResponse<string>> AddBookToSubscription(Guid _bookID, Guid _subscriptionID)
        {
            try
            {
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                if (subscription == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Subscription not found"
                    };
                }
                subscription.EBooks.Add(await pubHubDBContext.EBooks.FindAsync(_bookID));
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode= HttpStatusCode.OK,
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to add book to subscription"
                };
            }
        }

        public async Task<ApiResponse<string>> RemoveBookFromSubscription(Guid _bookID, Guid _subscriptionID)
        {
            try
            {
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                if (subscription == null)
                {
                    return new ApiResponse<string>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "Subscription not found"
                    };
                }
                subscription.EBooks.Remove(await pubHubDBContext.EBooks.FindAsync(_bookID));
                await pubHubDBContext.SaveChangesAsync();
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.OK,
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<string>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying remove book subscription"
                };
            }
        }

        public async Task<ApiResponse<List<PubHubEBook>>> GetAllBooksFromSubscription(Guid _subscriptionID)
        {
            try
            {
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                if (subscription == null)
                {
                    return new ApiResponse<List<PubHubEBook>>
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessage = "subscription not found"
                    };
                }
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.OK,
                    Data = subscription.EBooks.ToList()
                };
            }
            catch (Exception ex)
            {
                //TODO: Add logger
                return new ApiResponse<List<PubHubEBook>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all books from subscription"
                };
            }
        }

        public async Task<ApiResponse<double>> GetTotalErningsFromSubscription(Guid _subscriptionID)
        {
            //TODO: Do later
            throw new NotImplementedException();
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #endregion

        #region Ebook Endpoints

        public async Task<ApiResponse<List<PubHubEBook>>> GetAllBooksFromUserByID(string _userID)
        {
            //TODO:Figure this out
            throw new NotImplementedException();
            try
            {
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<ApiResponse<double>> GetAllEarningsFromBookByID(Guid _bookID)
        {
            //TODO:Figure this out
            throw new NotImplementedException();
            try
            {
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #endregion

        #region Logs Endpoints

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
                //TODO: Add logger
                return new ApiResponse<PubHubLog>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get log"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all logs"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all logs from entity"
                };
            }
        }

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
                //TODO: Add logger
                return new ApiResponse<List<PubHubLog>>
                {
                    StatusCode= HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get all logs for acquired"
                };
            }
        }

        #endregion

        #region Receipt Endpoints

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
                //TODO: Add logger
                return new ApiResponse<PubHubReceipt>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = "Internal server error while trying to get newest receipt fron user"
                };
            }
        }

        public async Task<ApiResponse<double>> GetTotalFromAcquired(Guid _userID)
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
                //TODO: Add logger
                return new ApiResponse<double>
                {
                    StatusCode = HttpStatusCode.InsufficientStorage,
                    ErrorMessage = "Internal server error while trying to get total from acquired"
                };
            }
        } 

        #endregion
    }
}
