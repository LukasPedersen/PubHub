using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PubHubWebServer.Data.Models;

namespace PubHubWebServer.Services
{
    public interface IPubHubServices
    {
        #region Generic EndPoints

        public Task<ApiResponse<string>> AddSingleEntity<T>(T _entity);

        public Task<ApiResponse<string>> AddMultipleEntities<T>(T _entities);

        public Task<ApiResponse<string>> UpdateEntity<T>(T _entity);

        public Task<ApiResponse<string>> UpdateMultipleEntities<T>(T _entities);

        public Task<ApiResponse<T>> GetEntityByID<T>(Guid _entityID);

        public Task<ApiResponse<string>> DeleteEntity<T>(T _entity);

        public Task<ApiResponse<string>> DeleteMultipleEntities<T>(T _entity);

        #endregion

        #region User Endpoints

        public Task<ApiResponse<IdentityRole>> GetUserRoles(string _userID);

        public Task<ApiResponse<string>> DeactivateUser(string _userID);

        #endregion

        #region Publisher Endpoints

        public Task<ApiResponse<List<PubHubSubscription>>> GetAllPublishersSubscriptions(Guid _readerID);

        public Task<ApiResponse<List<PubHubEBook>>> GetAllPublishersBooks(Guid _readerID);

        public Task<ApiResponse<double>> GetTotalEarnings(Guid _userID);

        public Task<ApiResponse<bool>> DoesPublisherOwnBook(string _publisherID, Guid _bookID);

        #endregion

        #region Reader Endpoints

        public Task<ApiResponse<List<PubHubSubscription>>> GetAllReadersSubscriptions(Guid _readerID);

        public Task<ApiResponse<List<PubHubEBook>>> GetAllReadersBooks(Guid _readerID);

        public Task<ApiResponse<double>> GetTotalSpendings(Guid _userID);

        #endregion

        #region Subscription Endpoints

        public Task<ApiResponse<string>> AddBookToSubscription(Guid _bookID, Guid _subscriptionID);

        public Task<ApiResponse<string>> RemoveBookFromSubscription(Guid _bookID, Guid _subscriptionID);

        public Task<ApiResponse<List<PubHubEBook>>> GetAllBooksFromSubscription(Guid _subscriptionID);

        public Task<ApiResponse<double>> GetTotalErningsFromSubscription(Guid _subscriptionID);

        public Task<ApiResponse<List<PubHubSubscription>>> GetTopSubscriptions();

        public Task<ApiResponse<List<PubHubSubscription>>> GetAllSubscriptionsWithBook(Guid _bookID);

        #endregion

        #region Ebook Endpoints

        public Task<ApiResponse<List<PubHubEBook>>> GetAllBooksFromUserByID(string _userID);

        public Task<ApiResponse<double>> GetAllEarningsFromBookByID(Guid _bookID);

        public Task<ApiResponse<List<PubHubEBook>>> GetTopBooks();

        public Task<ApiResponse<PubHubEBook>> GetBookByID(Guid ID);


        //public Task<ApiResponse<List<byte[]>>> GetBookImage(string _path);

        #endregion

        #region Logs Endpoints

        public Task<ApiResponse<List<PubHubLog>>> GetAllLogs();

        public Task<ApiResponse<List<PubHubLog>>> GetAllLogsOnEntityByID(Guid _EntityID);

        public Task<ApiResponse<List<PubHubLog>>> GetAllLogsForAcquired();

        #endregion

        #region Receipt Endpoints

        public Task<ApiResponse<PubHubReceipt>> GetNewestReceiptFromUser(Guid _userID);

        public Task<ApiResponse<double>> GetTotalFromAcquired(Guid _userID);

        #endregion

        #region Other

        public Task<ApiResponse<bool>> AnyUsersInDB();

        #endregion
    }
}
