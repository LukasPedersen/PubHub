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

        public Task<ServiceResponse<IdentityRole>> GetUserRoles(string _userID);

        public Task<ServiceResponse<bool>> DeactivateUser(string _userID);

        #endregion

        #region Publisher Endpoints

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllPublishersSubscriptions( Guid _readerID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllPublishersBooks(string _userID);

        public Task<ServiceResponse<double>> GetTotalEarnings(Guid _userID);

        public Task<ServiceResponse<bool>> DoesPublisherOwnBook(string _publisherID, Guid _bookID);

        public Task<ServiceResponse<bool>> DoesPublisherOwnSubscription(string _userID, Guid _SubscriptionID);
      
        public Task<ServiceResponse<bool>> CreateBook(string _userID, PubHubEBook Thebook);

        public Task<ServiceResponse<bool>> CreateSubscription(string _userID, PubHubSubscription subscription);

        #endregion

        #region Reader Endpoints

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllReadersSubscriptions(string _userID);

        public Task<ServiceResponse<bool>> UnSubFromSubscription(string _userID, Guid _subscriptioID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllBooksFromAllReaderSubscriptions(string _userID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllReadersBooks( string _userID);

        public Task<ServiceResponse<double>> GetTotalSpendings(string _userID);

        #endregion

        #region Subscription Endpoints

        public Task<ServiceResponse<bool>> AddBookToSubscription( string _userID, Guid _bookID, Guid _subscriptionID);

        public Task<ServiceResponse<bool>> RemoveBookFromSubscription( Guid _bookID, Guid _subscriptionID);

        public Task<ServiceResponse<bool>> ReaderSubscripeToBook(string _userID, Guid _SubscriptionID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllBooksFromSubscription(Guid _subscriptionID);

        public Task<ServiceResponse<List<PubHubSubscription>>> GetSubscriptionByFilter(DateTime startDate, DateTime endDate, string _title = "", int _skip = 0, int _take = 10);

        public Task<ServiceResponse<PubHubSubscription>> GetSubscriptionByID(Guid _subscriptionID);

        public Task<ServiceResponse<double>> GetTotalErningsFromSubscription(Guid _subscriptionID);

        public Task<ServiceResponse<bool>> UpdateSubscription(string _publisherID, PubHubSubscription _subscription);

        public Task<ServiceResponse<List<PubHubSubscription>>> GetTopSubscriptions(int _amount, Guid? _publiser = null);

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllSubscriptions();

        public Task<ServiceResponse<List<PubHubSubscription>>> GetAllSubscriptionsWithBook(Guid _bookID);

        public Task<ServiceResponse<int>> GetTotalSubscrbersOnSubscription(Guid _SubscriptionID);



        #endregion

        #region Ebook Endpoints

        public Task<ServiceResponse<List<PubHubEBook>>> GetAllBooksFromUserByID(string _userID);

        public Task<ServiceResponse<double>> GetAllEarningsFromBookByID(Guid _bookID);

        public Task<ServiceResponse<List<PubHubEBook>>> GetTopBooks(int _amount, Guid? _publisher = null);

        public Task<ServiceResponse<List<PubHubEBook>>> GetBooksByFilter(string _title = "", string _author = "", string _genre = "", int _skip = 0, int _take = 10);


        public Task<ServiceResponse<bool>> ReaderRentBook(Guid _reader, PubHubSubscription _newsubscription, List<PubHubEBook> _RentedBoks);

        public Task<ServiceResponse<bool>> ReaderBuyBook(string _readerID, Guid _bookID);

        public Task<ServiceResponse<PubHubEBook>> GetBookByID( Guid ID);

        public Task<ServiceResponse<bool>> UpdateBook(string _publisherID, PubHubEBook book);
        public Task<ServiceResponse<bool>> UpdateBookImage(string _publisherID, Guid _bookID, IBrowserFile _file);
        public Task<ServiceResponse<bool>> UpdateBookFile(string _publisherID, Guid _bookID, IBrowserFile _file);

        public Task<ServiceResponse<List<PdfDocument>>> GetBookPages(int _FirstPage, int _SecondPage, Guid _bookid);
        //public Task<ApiResponse<List<byte[]>>> GetBookImage(string _path);
        public Task<ServiceResponse<int>> GetAmountOfSubscriberOnBook(Guid _BookID);

        #endregion

        #region Logs Endpoints

        public Task<ServiceResponse<List<PubHubLog>>> GetAllLogs();

        public Task<ServiceResponse<List<PubHubLog>>> GetAllLogsOnFilter(Guid _EntityID, DateTime _startdate, DateTime _EndDate, LogType? type);

        public Task<ServiceResponse<List<PubHubLog>>> GetAllLogsForAcquired();


        #endregion

        #region Receipt Endpoints

        public Task<ServiceResponse<PubHubReceipt>> GetNewestReceiptFromUser(Guid _userID);

        public Task<ServiceResponse<double>> GetTotalFromAcquired(Guid _userID);

        public Task<ServiceResponse<List<PubHubReceipt>>> GetReceiptByFilter(Guid _EntityID, Guid _AcuiredID, DateTime _startdate, DateTime _EndDate);

        #endregion

        #region Other
        public Task SaveLog(string _message, LogType _logType = LogType.Information, Guid? _EntiryID = null);

        public Task<ServiceResponse<List<ApplicationUser>>> FindUserAdminRights(string _email, string _username);

        #endregion
    }
}
