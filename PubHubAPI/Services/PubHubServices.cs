using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PubHubAPI.Data;
using PubHubAPI.Data.Models;

namespace PubHubAPI.Services
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

        public async Task<HttpStatusCode> AddSingleEntity<T>(T _entity)
        {
            try
            {
                await pubHubDBContext.AddAsync(_entity);
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<HttpStatusCode> AddMultipleEntities<T>(T _entities)
        {
            try
            {
                await pubHubDBContext.AddRangeAsync(_entities);
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<HttpStatusCode> UpdateEntity<T>(T _entity)
        {
            try
            {
                pubHubDBContext.Update(_entity);
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<HttpStatusCode> UpdateMultipleEntities<T>(T _entities)
        {
            try
            {
                pubHubDBContext.UpdateRange(_entities);
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<(HttpStatusCode, T)> GetEntityByID<T>(T _entityID)
        {
            try
            {
                return (HttpStatusCode.OK, (T)await pubHubDBContext.FindAsync(_entityID.GetType(), _entityID));
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, default(T));
            }
        }

        public async Task<HttpStatusCode> DeleteEntity<T>(T _entity)
        {
            try
            {
                pubHubDBContext.Remove(_entity);
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<HttpStatusCode> DeleteMultipleEntities<T>(T _entity)
        {
            try
            {
                pubHubDBContext.RemoveRange(_entity);
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        #endregion

        #region User Endpoints

        public async Task<(HttpStatusCode, PubHubUser)> GetUserRoles(string _userID)
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Roles.FindAsync(await pubHubDBContext.Users.Where(u => u.Id == _userID).FirstAsync());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new PubHubUser());
            }
        }

        public async Task<HttpStatusCode> DeactivateUser(string _userID)
        {
            try
            {
                PubHubUser tempUser = await pubHubDBContext.Users.FindAsync(_userID);
                tempUser.Active = false;
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        #endregion

        #region Publisher Endpoints

        public async Task<(HttpStatusCode, List<PubHubSubscription>)> GetAllPublishersSubscriptions(Guid _readerID)
        {
            try
            {
                PubHubPublisher user = await pubHubDBContext.Publishers.FindAsync(_readerID);
                return (HttpStatusCode.OK, user.Subscriptions.ToList());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new List<PubHubSubscription>());
            }
        }

        public async Task<(HttpStatusCode, List<PubHubEBook>)> GetAllPublishersBooks(Guid _readerID)
        {
            try
            {
                PubHubPublisher user = await pubHubDBContext.Publishers.FindAsync(_readerID);
                return (HttpStatusCode.OK, user.EBooks.ToList());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new List<PubHubEBook>());
                throw;
            }
        }

        public async Task<(HttpStatusCode, double)> GetTotalEarnings(Guid _userID)
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

        public async Task<(HttpStatusCode, List<PubHubSubscription>)> GetAllReadersSubscriptions(Guid _readerID)
        {
            try
            {
                PubHubReader user = await pubHubDBContext.Readers.FindAsync(_readerID);
                return (HttpStatusCode.OK, user.Subscriptions.ToList());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new List<PubHubSubscription>());
                throw;
            }
        }

        public async Task<(HttpStatusCode, List<PubHubEBook>)> GetAllReadersBooks(Guid _readerID)
        {
            try
            {
                PubHubReader user = await pubHubDBContext.Readers.FindAsync(_readerID);
                return (HttpStatusCode.OK, user.EBooks.ToList());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new List<PubHubEBook>());
                throw;
            }
        }

        public async Task<(HttpStatusCode, double)> GetTotalSpendings(Guid _userID)
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


        public async Task<HttpStatusCode> AddBookToSubscription(Guid _bookID, Guid _subscriptionID)
        {
            try
            {
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                subscription.EBooks.Add(await pubHubDBContext.EBooks.FindAsync(_bookID));
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<HttpStatusCode> RemoveBookFromSubscription(Guid _bookID, Guid _subscriptionID)
        {
            try
            {
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                subscription.EBooks.Remove(await pubHubDBContext.EBooks.FindAsync(_bookID));
                await pubHubDBContext.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return HttpStatusCode.BadRequest;
            }
        }

        public async Task<(HttpStatusCode, List<PubHubEBook>)> GetAllBooksFromSubscription(Guid _subscriptionID)
        {
            try
            {
                PubHubSubscription subscription = await pubHubDBContext.Subscriptions.FindAsync(_subscriptionID);
                return (HttpStatusCode.OK, subscription.EBooks.ToList());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new List<PubHubEBook>());
            }
        }

        public async Task<(HttpStatusCode, double)> GetTotalErningsFromSubscription(Guid _subscriptionID)
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

        #region Ebook Endpoints

        public async Task<(HttpStatusCode, List<PubHubEBook>)> GetAllBooksFromUserByID(string _userID)
        {
            //TODO:Figure this out
            throw new NotImplementedException();
            try
            {
                
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<(HttpStatusCode, double)> GetAllEarningsFromBookByID(Guid _bookID)
        {
            //TODO:Figure this out
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

        #region Logs Endpoints

        public async Task<(HttpStatusCode, PubHubLog)> GetLogByID(Guid _logID)
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Logs.Where(l => l.EntityID == _logID).FirstAsync());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new PubHubLog());
            }
        }

        public async Task<(HttpStatusCode, List<PubHubLog>)> GetAllLogs()
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Logs.ToListAsync());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new List<PubHubLog>());
            }
        }

        public async Task<(HttpStatusCode, List<PubHubLog>)> GetAllLogsOnEntityByID(Guid _EntityID)
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Logs.Where(l => l.EntityID == _EntityID).ToListAsync());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.OK, new List<PubHubLog>());
            }
        }

        public async Task<(HttpStatusCode, List<PubHubLog>)> GetAllLogsForAcquired()
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Logs.Where(l => l.Message.ToUpper().Contains("ACQUIRED")).ToListAsync());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.OK, new List<PubHubLog>());
            }
        }

        #endregion

        #region Receipt Endpoints

        public async Task<(HttpStatusCode, PubHubReceipt)> GetSingleReceipt(Guid _receiptID)
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Receipts.Where(r => r.EntityID == _receiptID).FirstAsync());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new PubHubReceipt());
            }
        }

        public async Task<(HttpStatusCode, PubHubReceipt)> GetNewestReceiptFromUser(Guid _userID)
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Receipts.Where(r => r.EntityID == _userID).OrderByDescending(r => r.TimeStamp).FirstAsync());
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new PubHubReceipt());
            }
        }

        public async Task<(HttpStatusCode, double)> GetTotalFromAcquired(Guid _userID)
        {
            try
            {
                return (HttpStatusCode.OK, await pubHubDBContext.Receipts.Where(r => r.EntityID == _userID).SumAsync(r => r.Price));
            }
            catch (Exception e)
            {
                //TODO: Add logger
                return (HttpStatusCode.BadRequest, new double());
            }
        } 

        #endregion
    }
}
