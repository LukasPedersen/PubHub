using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using PubHubWebServer.Data;
using PubHubWebServer.Data.Models;

namespace PubHubWebServer.Services
{
    public interface IPubHubServices
    {
        #region Generic EndPoints

        public Task<ServiceResponse<bool>> AddSingleEntity<T>(T _entity);

        public Task<ServiceResponse<bool>> AddMultipleEntities<T>(T _entities);

        public Task<ServiceResponse<bool>> UpdateEntity<T>(T _entity);

        public Task<ServiceResponse<bool>> UpdateMultipleEntities<T>(T _entities);

        public Task<ServiceResponse<T>> GetEntityByID<T>(Guid _entityID);

        public Task<ServiceResponse<List<T>>> GetMultipleEntitiesByIDs<T>(List<Guid> _entityID);

        public Task<ServiceResponse<bool>> DeleteEntity<T>(T _entity);

        public Task<ServiceResponse<bool>> DeleteMultipleEntities<T>(T _entity);

        #endregion

        #region User Endpoints

        public Task<ServiceResponse<IdentityRole>> GetUserRoles(ClaimsPrincipal user, string _userID);

        public Task<ServiceResponse<bool>> DeactivateUser(ClaimsPrincipal user, string _userID);

        #endregion

        #region Publisher Endpoints

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllPublishersSubscriptions(ClaimsPrincipal user, Guid _readerID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllPublishersBooks(ClaimsPrincipal user, string _userID);

        public Task<ServiceResponse<double>> GetTotalEarnings(ClaimsPrincipal user, Guid _userID);

        public Task<ServiceResponse<bool>> DoesPublisherOwnBook(ClaimsPrincipal user, string _publisherID, Guid _bookID);

        public Task<ServiceResponse<bool>> DoesPublisherOwnSubscription(ClaimsPrincipal user, string _userID, Guid _SubscriptionID);
      
        public Task<ServiceResponse<bool>> CreateBook(ClaimsPrincipal user, string _userID, PubHubEBook Thebook);

        public Task<ServiceResponse<bool>> CreateSubscription(ClaimsPrincipal user, string _userID, PubHubSubscription subscription);

        #endregion

        #region Reader Endpoints

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllReadersSubscriptions(ClaimsPrincipal user, string _userID);

        public Task<ServiceResponse<bool>> UnSubFromSubscription(ClaimsPrincipal user, string _userID, Guid _subscriptioID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllBooksFromAllReaderSubscriptions(ClaimsPrincipal user, string _userID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllReadersBooks(ClaimsPrincipal user, string _userID);

        public Task<ServiceResponse<double>> GetTotalSpendings(ClaimsPrincipal user, string _userID);

        #endregion

        #region Subscription Endpoints

        public Task<ServiceResponse<bool>> AddBookToSubscription(ClaimsPrincipal user, string _userID, Guid _bookID, Guid _subscriptionID);

        public Task<ServiceResponse<bool>> RemoveBookFromSubscription(ClaimsPrincipal user, Guid _bookID, Guid _subscriptionID);

        public Task<ServiceResponse<bool>> ReaderSubscripeToBook(ClaimsPrincipal user, string _userID, Guid _SubscriptionID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllBooksFromSubscription(ClaimsPrincipal user, Guid _subscriptionID);

        public Task<ServiceResponse<List<PubHubSubscription>>> GetSubscriptionByFilter(ClaimsPrincipal user, DateTime startDate, DateTime endDate, string _title = "", int _skip = 0, int _take = 10);

        public Task<ServiceResponse<PubHubSubscription>> GetSubscriptionByID(Guid _subscriptionID);

        public Task<ServiceResponse<double>> GetTotalErningsFromSubscription(ClaimsPrincipal user, Guid _subscriptionID);

        public Task<ServiceResponse<bool>> UpdateSubscription(ClaimsPrincipal user, string _publisherID, PubHubSubscription _subscription);

        public Task<ServiceResponse<List<PubHubSubscription>>> GetTopSubscriptions(int _amount, Guid? _publiser = null);

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllSubscriptions();

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllSubscriptionsWithBook(ClaimsPrincipal user, Guid _bookID);

        public Task<ServiceResponse<int>> GetTotalSubscrbersOnSubscription(ClaimsPrincipal user, Guid _SubscriptionID);



        #endregion

        #region Ebook Endpoints

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllBooksFromUserByID(ClaimsPrincipal user, string _userID);

        public Task<ServiceResponse<double>> GetAllEarningsFromBookByID(ClaimsPrincipal user, Guid _bookID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetTopBooks(ClaimsPrincipal user, int _amount, Guid? _publisher = null);

        public Task<ServiceResponse<List<PubHubEBook>>> GetBooksByFilter(string _title = "", string _author = "", string _genre = "", int _skip = 0, int _take = 10);

        public Task<ServiceResponse<bool>> IncreaseBookDownloadCount(ClaimsPrincipal user, string _userID, string _bookName);

        public Task<ServiceResponse<bool>> ReaderRentBook(ClaimsPrincipal user, Guid _reader, PubHubSubscription _newsubscription, List<PubHubEBook> _RentedBoks);

        public Task<ServiceResponse<bool>> ReaderBuyBook(ClaimsPrincipal user, string _readerID, Guid _bookID);

        public Task<ServiceResponse<PubHubEBook>> GetBookByID(ClaimsPrincipal user, Guid ID);

        public Task<ServiceResponse<bool>> UpdateBook(ClaimsPrincipal user, string _publisherID, PubHubEBook book);
        public Task<ServiceResponse<bool>> UpdateBookImage(ClaimsPrincipal user, string _publisherID, Guid _bookID, IBrowserFile _file);
        public Task<ServiceResponse<bool>> UpdateBookFile(ClaimsPrincipal user, string _publisherID, Guid _bookID, IBrowserFile _file);

        public Task<ServiceResponse<List<PdfDocument>>> GetBookPages(ClaimsPrincipal user, int _FirstPage, int _SecondPage, Guid _bookid);
        //public Task<ApiResponse<List<byte[]>>> GetBookImage(string _path);
        public Task<ServiceResponse<int>> GetAmountOfSubscriberOnBook(ClaimsPrincipal user, Guid _BookID);

        #endregion

        #region Logs Endpoints

        public Task<ServiceResponse<List<PubHubLog>>> GetAllLogs(ClaimsPrincipal user);

        public Task<ServiceResponse<List<PubHubLog>>> GetAllLogsOnFilter(ClaimsPrincipal user, Guid _EntityID, DateTime _startdate, DateTime _EndDate, LogType? type);

        public Task<ServiceResponse<List<PubHubLog>>> GetAllLogsForAcquired(ClaimsPrincipal user);


        #endregion

        #region Receipt Endpoints

        public Task<ServiceResponse<PubHubReceipt>> GetNewestReceiptFromUser(Guid _userID);

        public Task<ServiceResponse<double>> GetTotalFromAcquired(Guid _userID);

        public Task<ServiceResponse<List<PubHubReceipt>>> GetReceiptByFilter(ClaimsPrincipal user, Guid _EntityID, Guid _AcuiredID, DateTime _startdate, DateTime _EndDate);

        #endregion

        #region Other
        public Task SaveLog(string _message, LogType _logType = LogType.Information, Guid? _EntiryID = null);

        public Task<ServiceResponse<List<ApplicationUser>>> FindUserAdminRights(string _email, string _username);

        #endregion
    }
}
