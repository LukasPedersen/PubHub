using PubHubWebServer.Data;
using PubHubWebServer.Data.Models;
using PubHubWebServer.Services;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace TestProject1
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            //Make the context
            _context = ContextGenerator.Generator();

            //Create the service
            _Services = new PubHubServices(_context);
        }

        private readonly PubHubDBContext _context;
        public PubHubServices _Services;

        public Guid ReaderID { get; set; } = Guid.Parse("802C8048-63D7-4F2A-8F19-DBFD8207C623");

        public Guid BookId { get; set; } = Guid.Parse("2759DE72-EA20-46DB-AEF7-6C0A33FCD790");
        public Guid RealBookID { get; set; } = Guid.Parse("7FDCFF5D-EEA6-4F3D-B79C-60B929B4BF38");
        public Guid SubscriptionID { get; set; } = Guid.Parse("9FAD97EB-BC56-42B9-8737-33F21D24D59E");

        public PubHubEBook TheBook { get; set; } = new()
        {
            EBookID = Guid.Parse("2759DE72-EA20-46DB-AEF7-6C0A33FCD790"),
            AuthorNames = "Jens",
            Available = true,
            BorrowPrice = 9.9,
            Price = 99.9,
            DownloadCount = 0,
            Title = "This is the title Created By test",
            FilePath = "This-is-the-title",
            Genre = "Everyrthing",
            PageCount = 0,
            Description = "this is the description",

        };

        public PubHubSubscription TheSubscription { get; set; } = new()
        {
            Active = true,
            EndDate = DateTime.Now,
            Message = "",
            Price = 99.9,
            StartDate = DateTime.Now,
            SubscriptionID = Guid.Parse("9FAD97EB-BC56-42B9-8737-33F21D24D59E"),
            Title = "Subscription Title from Test"
        };

        [Fact]
        public async void GetAllSubscription()
        {
            var ServiceSubs = await _Services.GetAllSubscriptions();
            List<PubHubSubscription> subscriptions = ServiceSubs.Data;

            Assert.True(subscriptions.Count > 0);
        }
        [Fact]
        public async void getBooksByFilter()
        {
            var serviceBooks = await _Services.GetBooksByFilter();
            List<PubHubEBook> books = serviceBooks.Data;
            Assert.True(books.Count > 0);
        }

        [Fact]
        public async void getBooksByFilterOnTiyle()
        {
            var serviceBooks = await _Services.GetBooksByFilter("The ");
            List<PubHubEBook> books = serviceBooks.Data;
            Assert.True(books.Count > 0);
        }

        [Fact]
        public async void InsertBook()
        {
            var result = await _Services.AddSingleEntity<PubHubEBook>(TheBook);

            Assert.True(result.Data == true);
            //Crean up
            await _Services.DeleteEntity<PubHubEBook>(TheBook);
        }

        [Fact]
        public async void GetBook()
        {
            await _Services.AddSingleEntity<PubHubEBook>(TheBook);

            var result = await _Services.GetBookByID(BookId);
            PubHubEBook book = result.Data;

            Assert.True(book != null);
            //Crean up
            await _Services.DeleteEntity<PubHubEBook>(TheBook);
        }

        [Fact]
        public async void DeleteBook()
        {

            await _Services.AddSingleEntity<PubHubEBook>(TheBook);

            //Find the book needed to delete
            var result = await _Services.GetBookByID(BookId);
            PubHubEBook book = result.Data;

            //Remove the book in question
            var resultdelete = await _Services.DeleteEntity<PubHubEBook>(book);

            Assert.True(resultdelete.Data == true);
        }

        [Fact]
        public async void GetAllLogs()
        {
            var result = await _Services.GetAllLogs();

            Assert.True(result.Data.Count > 0);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(10, 11)]
        [InlineData(50, 51)]
        public async void GetBookPages(int one, int two)
        {
            var result = await _Services.GetBookPages(one, two, RealBookID);

            List<IronPdf.PdfDocument> pages = result.Data;

            Assert.True(pages.Count  == 2);
        }

        [Fact]
        public async void ReaderBuyBook()
        {
            var result = await _Services.ReaderBuyBook("1fe12077-ee83-4362-86e4-136d8368b6a3", RealBookID);

            Assert.True(result.Data);

        }

        [Fact]
        public async void ReaderRentBook()
        {
            List<PubHubEBook> templist = new();
            var bookresult = await _Services.GetBookByID(RealBookID);
            templist.Add(bookresult.Data);

            var result = await _Services.ReaderRentBook(ReaderID, TheSubscription, templist);

            Assert.True(result.Data);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public async void GetTopBook(int amount)
        {
            var result = await _Services.GetTopBooks(amount);

            Assert.True(result.Data.Count == amount);
        }

        [Fact]
        public async void CreateSubscription()
        {
            var result = await _Services.CreateSubscription("b4665254-1122-480e-9473-7a945a0c753e", TheSubscription);

            Assert.True(result.Data);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public async void TopSubs(int amount)
        {
            var result = await _Services.GetTopSubscriptions(amount);

            Assert.True(result.Data.Count == amount);
        }

    }
}