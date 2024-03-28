using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PubHubAPI.Data.Models;

namespace PubHubAPI.Services
{
    public interface IPubHubServices
    {
        #region Generic EndPoints

        public Task<HttpStatusCode> AddSingleEntity<T>(T _entity);

        public Task<HttpStatusCode> AddMultipleEntities<T>(T _entities);

        public Task<HttpStatusCode> UpdateEntity<T>(T _entity);

        public Task<HttpStatusCode> UpdateMultipleEntities<T>(T _entities);

        public Task<(HttpStatusCode, T)> GetEntityByID<T>(T _entityID);

        public Task<HttpStatusCode> DeleteEntity<T>(T _entity);

        public Task<HttpStatusCode> DeleteMultipleEntities<T>(T _entity);

        #endregion

        #region User Endpoints

        public Task<(HttpStatusCode, PubHubUser)> GetUserRoles(string _userID);

        public Task<HttpStatusCode> DeactivateUser(string _userID);

        #endregion

        #region Publisher Endpoints

        public Task<(HttpStatusCode, List<PubHubSubscription>)> GetAllPublishersSubscriptions(Guid _readerID);

        public Task<(HttpStatusCode, List<PubHubEBook>)> GetAllPublishersBooks(Guid _readerID);

        public Task<(HttpStatusCode, double)> GetTotalEarnings(Guid _userID);

        #endregion

        #region Reader Endpoints

        public Task<(HttpStatusCode, List<PubHubSubscription>)> GetAllReadersSubscriptions(Guid _readerID);

        public Task<(HttpStatusCode, List<PubHubEBook>)> GetAllReadersBooks(Guid _readerID);

        public Task<(HttpStatusCode, double)> GetTotalSpendings(Guid _userID);

        #endregion

        #region Subscription Endpoints

        public Task<HttpStatusCode> AddBookToSubscription(Guid _bookID, Guid _subscriptionID);

        public Task<HttpStatusCode> RemoveBookFromSubscription(Guid _bookID, Guid _subscriptionID);

        public Task<(HttpStatusCode, List<PubHubEBook>)> GetAllBooksFromSubscription(Guid _subscriptionID);

        public Task<(HttpStatusCode, double)> GetTotalErningsFromSubscription(Guid _subscriptionID);

        #endregion

        #region Ebook Endpoints

        public Task<(HttpStatusCode, List<PubHubEBook>)> GetAllBooksFromUserByID(string _userID);

        public Task<(HttpStatusCode, double)> GetAllEarningsFromBookByID(Guid _bookID);

        #endregion

        #region Logs Endpoints

        public Task<(HttpStatusCode, PubHubLog)> GetLogByID(Guid _logID);

        public Task<(HttpStatusCode, List<PubHubLog>)> GetAllLogs();

        public Task<(HttpStatusCode, List<PubHubLog>)> GetAllLogsOnEntityByID(Guid _EntityID);

        public Task<(HttpStatusCode, List<PubHubLog>)> GetAllLogsForAcquired();

        #endregion

        #region Receipt Endpoints

        public Task<(HttpStatusCode, PubHubReceipt)> GetSingleReceipt(Guid _receiptID);

        public Task<(HttpStatusCode, PubHubReceipt)> GetNewestReceiptFromUser(Guid _userID);

        public Task<(HttpStatusCode, double)> GetTotalFromAcquired(Guid _userID);

        #endregion
    }
}
