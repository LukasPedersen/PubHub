<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/LukasPedersen/PubHub">
    <img src="https://github.com/LukasPedersen/PubHub/assets/61869988/8d04f225-243b-415d-8749-9b0067861de4" alt="Logo" width="420" height="250">
  </a>

  <h3 align="center">PubHub Readme</h3>

  <p align="center">
    Online library
    <br />
    <a href="https://github.com/LukasPedersen/PubHub/tree/Development">View Demo</a>
    ·
    <a href="https://github.com/LukasPedersen/PubHub/issues">Report Bug</a>
    ·
    <a href="https://github.com/LukasPedersen/PubHub/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#roadmap">API documentation</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project


Der bliver udgivet flere og flere e-bøger, så der skal oprettes et system der kan håndtere dette. Hidtil har forlagene selv stået for at distribuere bøgerne, men nu ønsker man en løsning hvor forlag har mulighed for at kunne administrere deres indhold, som kunderne let kan tilgå, samt på længere sigt streaming af podcasts. Denne hub skal samtidigt generere statistik og afregning af indholdsleverandørerne, så det bliver lettere for dem at holde styr på deres oversigt og lettere at distribuere deres indhold.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

This any major frameworks/libraries used to bootstrap this project.

* [ASP.Net Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0)
* [Blazor Server in .NET 8](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-8.0)
* [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [Identity](https://learn.microsoft.com/en-us/entra/identity-platform/)
* [Bootstrap](https://getbootstrap.com)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This is an example of how to setup up the project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* npm
  ```sh
  npm install npm@latest -g
  ```

### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._

1. Clone the repo
   ```sh
   git clone https://github.com/LukasPedersen/PubHub.git
   ```
2. Install NPM packages
   ```sh
   npm install
   ```
3. Enter your connectionString in `appsettings.json`
  ```json
   "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=YourDBName;Trusted_Connection=True;MultipleActiveResultSets=true"
   ```
4. Setup your database in NPM Console
  ```sh
   Update-Database
   ```
5. Start application


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.

_For more examples, please refer to the [Documentation](https://example.com)_

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Functionality Roadmap
<details>
  <summary>Roadmap</summary>   
  
### Reader Roadmap  
---  
  
- [ ] Reader functionality
  - [ ] Subscriptions
    - [ ] Create Custom subscriptions
    - [ ] View Custom subscriptions
    - [ ] Edit Custom subscriptions
    - [ ] Delete Custom subscriptions
    - [X] Subscribe to subscriptions
    - [x] View subscribed subscriptions
    - [X] Unsubscribe from subscriptions
  - [x] Ebooks
    - [x] Buy Ebook
    - [x] Download Ebook
    - [x] Read Ebook online
  - [x] Management
    - [x] Overview over owend Ebooks
    - [x] Overview over owend Subscriptions
    - [x] Overview over Ebooks from Subscriptions
  - [x] Profile Management
    - [x] Update Email
    - [x] Update Password
    - [x] 2FA Management
    - [x] Delete profile
### Publisher Roadmap  
---  
- [x] Publisher functionality
  - [ ] Subscriptions
    - [ ] Create Subscriptions
    - [x] View Subscriptions
    - [x] Edit Subscriptions
    - [x] Add Ebook to Subscriptions
    - [x] Remove Ebook from Subscriptions
  - [x] Ebooks
    - [x] Create Ebooks
    - [x] Edit Ebooks
    - [x] View Ebooks
    - [x] Deactivate Ebooks
  - [x] Management
    - [x] Overview over owend Ebooks
    - [x] Overview over owend Subscriptions
    - [x] Overview over Ebooks from Subscriptions
    - [x] Overview over statistics
  - [x] Profile Management
    - [x] Update Email
    - [x] Update Password
    - [x] 2FA Management
    - [x] Delete profile
### Publisher Roadmap  
---  
- [ ] Admin functionality
  - [x] Overview over logs
  - [x] Overview over receipts
  - [x] Overview over users
  - [x] Creation of publishers
  - [x] Creation of admins

See the [open issues](https://github.com/LukasPedersen/PubHub/issues) for a full list of proposed features (and known issues).
</details>
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- API Endpoints documentation -->
## Services documentation
<details>
  <summary>Services Endpoints</summary>   
     
  ### Generic Services   
  
| Service                                   | Parameters                                  | Returns                                 | Description                                             |
|-------------------------------------------|---------------------------------------------|-----------------------------------------|---------------------------------------------------------|
| AddSingleEntity<T>(_entity)               | _entity: T                                  | Task\<ServiceResponse\<bool>>            | Adds a single entity to the database.                   |
| AddMultipleEntities<T>(_entities)         | _entities: List\<T>                          | Task\<ServiceResponse\<bool>>            | Adds multiple entities to the database.                 |
| UpdateEntity<T>(_entity)                  | _entity: T                                  | Task\<ServiceResponse\<bool>>            | Updates a single entity in the database.                |
| UpdateMultipleEntities<T>(_entities)      | _entities: List\<T>                          | Task\<ServiceResponse\<bool>>            | Updates multiple entities in the database.              |
| GetEntityByID<T>(_entityID)              | _entityID: Guid                             | Task\<ServiceResponse\<T>>               | Retrieves an entity by its ID from the database.        |
| GetMultipleEntitiesByIDs<T>(_entityID)   | _entityID: List\<Guid>                       | Task\<ServiceResponse\<List<T>>>          | Retrieves multiple entities by their IDs.              |
| DeleteEntity<T>(_entity)                 | _entity: T                                  | Task\<ServiceResponse\<bool>>            | Deletes a single entity from the database.             |
| DeleteMultipleEntities<T>(_entity)       | _entity: List\<T>                            | Task\<ServiceResponse\<bool>>            | Deletes multiple entities from the database.           |
  
  ### User Services
  
| Service                           | Parameters                  | Returns                          | Description                                        |
|-----------------------------------|-----------------------------|----------------------------------|----------------------------------------------------|
| GetUserRoles(user, _userID)      | user: ClaimsPrincipal, <br> _userID: string   | Task\<ServiceResponse\<IdentityRole>> | Retrieves the roles of a user from the database.   |
| DeactivateUser(user, _userID)    | user: ClaimsPrincipal, <br> _userID: string   | Task\<ServiceResponse\<bool>>     | Deactivates a user in the database.               |
  
  ### Publisher Services
  
| Service                                          | Parameters                               | Returns                               | Description                                                     |
|--------------------------------------------------|------------------------------------------|---------------------------------------|-----------------------------------------------------------------|
| GetAllPublishersSubscriptions(user, _readerID)   | user: ClaimsPrincipal, <br> _readerID: Guid | Task\<ServiceResponse<List\<PubHubSubscription>>> | Retrieves all subscriptions belonging to a publisher.          |
| GetAllPublishersBooks(user, _userID)            | user: ClaimsPrincipal, <br> _userID: string | Task\<ServiceResponse\<List\<PubHubEBook>>>        | Retrieves all books belonging to a publisher.                 |
| GetTotalEarnings(user, _userID)                 | user: ClaimsPrincipal, <br> _userID: Guid   | Task\<ServiceResponse\<double>>                | Retrieves the total earnings of a publisher.                 |
| DoesPublisherOwnBook(user, _publisherID, _bookID) | user: ClaimsPrincipal, <br> _publisherID: string, <br> _bookID: Guid | Task\<ServiceResponse\<bool>>      | Checks if a publisher owns a specific book.                   |
| DoesPublisherOwnSubscription(user, _userID, _SubscriptionID) | user: ClaimsPrincipal, <br> _userID: string, <br> _SubscriptionID: Guid | Task\<ServiceResponse\<bool>> | Checks if a publisher owns a specific subscription.          |
| CreateBook(user, _userID, Thebook)             | user: ClaimsPrincipal, <br> _userID: string, <br> Thebook: PubHubEBook | Task\<ServiceResponse\<bool>>                | Creates a new book for a publisher.                           |
| CreateSubscription(user, _userID, subscription) | user: ClaimsPrincipal, <br> _userID: string, <br> subscription: PubHubSubscription | Task\<ServiceResponse\<bool>>    | Creates a new subscription for a publisher.                  |
  
  ### Reader Services
  
| Service                                               | Parameters                                     | Returns                                          | Description                                                     |
|-------------------------------------------------------|------------------------------------------------|--------------------------------------------------|-----------------------------------------------------------------|
| GetAllReadersSubscriptions(user, _userID)             | user: ClaimsPrincipal, <br> _userID: string    | Task\<ServiceResponse\<List\<PubHubSubscription>>> | Retrieves all subscriptions belonging to a reader.               |
| UnSubFromSubscription(user, _userID, _subscriptioID)  | user: ClaimsPrincipal, <br> _userID: string, <br> _subscriptioID: Guid | Task\<ServiceResponse\<bool>>         | Unsubscribes a reader from a specific subscription.             |
| GetAllBooksFromAllReaderSubscriptions(user, _userID)  | user: ClaimsPrincipal, <br> _userID: string    | Task\<ServiceResponse\<List\<PubHubEBook>>>       | Retrieves all books from all subscriptions of a reader.          |
| GetAllReadersBooks(user, _userID)                    | user: ClaimsPrincipal, <br> _userID: string    | Task\<ServiceResponse\<List\<PubHubEBook>>>       | Retrieves all books owned by a reader.                          |
| GetTotalSpendings(user, _userID)                     | user: ClaimsPrincipal, <br> _userID: string    | Task\<ServiceResponse\<double>>                  | Retrieves the total spendings of a reader.                      |
  
  ### Subscription Services
  
| Service                                               | Parameters                                     | Returns                                          | Description                                                     |
|-------------------------------------------------------|------------------------------------------------|--------------------------------------------------|-----------------------------------------------------------------|
| GetAllReadersSubscriptions(user, _userID)             | user: ClaimsPrincipal, <br> _userID: string    | Task<ServiceResponse\<List\<PubHubSubscription>>> | Retrieves all subscriptions belonging to a reader.               |
| UnSubFromSubscription(user, _userID, _subscriptioID)  | user: ClaimsPrincipal, <br> _userID: string, <br> _subscriptioID: Guid | Task\<ServiceResponse\<bool>>         | Unsubscribes a reader from a specific subscription.             |
| GetAllBooksFromAllReaderSubscriptions(user, _userID)  | user: ClaimsPrincipal, <br> _userID: string    | Task\<ServiceResponse\<List\<PubHubEBook>>>       | Retrieves all books from all subscriptions of a reader.          |
| GetAllReadersBooks(user, _userID)                    | user: ClaimsPrincipal, <br> _userID: string    | Task\<ServiceResponse\<List\<PubHubEBook>>>       | Retrieves all books owned by a reader.                          |
| GetTotalSpendings(user, _userID)                     | user: ClaimsPrincipal, <br> _userID: string    | Task\<ServiceResponse\<double>>                  | Retrieves the total spendings of a reader.                      |
  
  ### Ebook Services
  
| Service                                                | Parameters                                                       | Returns                                             | Description                                                     |
|--------------------------------------------------------|------------------------------------------------------------------|-----------------------------------------------------|-----------------------------------------------------------------|
| GetAllBooksFromUserByID(user, _userID)                 | user: ClaimsPrincipal, <br> _userID: string                      | Task\<ServiceResponse\<List\<PubHubEBook>>>          | Retrieves all books belonging to a user by ID.                   |
| GetAllEarningsFromBookByID(user, _bookID)              | user: ClaimsPrincipal, <br> _bookID: Guid                        | Task\<ServiceResponse\<double>>                     | Retrieves all earnings from a book by ID.                        |
| GetTopBooks(user, _amount, _publisher)                 | user: ClaimsPrincipal, <br> _amount: int, <br> _publisher: Guid? | Task\<ServiceResponse\<List\<PubHubEBook>>>          | Retrieves the top books by amount, optionally filtered by publisher. |
| GetBooksByFilter(_title, _author, _genre, _skip, _take)| _title: string = "", <br> _author: string = "", <br> _genre: string = "", <br> _skip: int = 0, <br> _take: int = 10 | Task\<ServiceResponse\<List\<PubHubEBook>>>    | Retrieves books based on specified filters.                       |
| ReaderRentBook(user, _reader, _newsubscription, _RentedBoks)| user: ClaimsPrincipal, <br> _reader: Guid, <br> _newsubscription: PubHubSubscription, <br> _RentedBoks: List\<PubHubEBook> | Task\<ServiceResponse\<bool>>           | Rents books to a reader.                                         |
| ReaderBuyBook(user, _readerID, _bookID)               | user: ClaimsPrincipal, <br> _readerID: string, <br> _bookID: Guid | Task\<ServiceResponse\<bool>>                       | Allows a reader to buy a book.                                   |
| GetBookByID(user, ID)                                 | user: ClaimsPrincipal, <br> ID: Guid                             | Task\<ServiceResponse\<PubHubEBook>>                 | Retrieves a book by its ID.                                      |
| UpdateBook(user, _publisherID, book)                   | user: ClaimsPrincipal, <br> _publisherID: string, <br> book: PubHubEBook | Task\<ServiceResponse\<bool>>                  | Updates a book.                                                  |
| UpdateBookImage(user, _publisherID, _bookID, _file)   | user: ClaimsPrincipal, <br> _publisherID: string, <br> _bookID: Guid, <br> _file: IBrowserFile | Task\<ServiceResponse\<bool>>                | Updates a book's image.                                          |
| UpdateBookFile(user, _publisherID, _bookID, _file)     | user: ClaimsPrincipal, <br> _publisherID: string, <br> _bookID: Guid, <br> _file: IBrowserFile | Task\<ServiceResponse\<bool>>                | Updates a book's file.                                           |
| GetBookPages(user, _FirstPage, _SecondPage, _bookid)   | user: ClaimsPrincipal, <br> _FirstPage: int, <br> _SecondPage: int, <br> _bookid: Guid | Task\<ServiceResponse\<List\<PdfDocument>>>   | Retrieves pages of a book.                                       |
| GetAmountOfSubscriberOnBook(user, _BookID)            | user: ClaimsPrincipal, <br> _BookID: Guid                        | Task\<ServiceResponse\<int>>                        | Retrieves the amount of subscribers on a book.                   |
  
  ### Logs Services
  

| Service                                       | Parameters                                                                                      | Returns                                    | Description                                       |
|-----------------------------------------------|-------------------------------------------------------------------------------------------------|--------------------------------------------|---------------------------------------------------|
| GetAllLogs(user)                              | user: ClaimsPrincipal                                                                          | Task\<ServiceResponse\<List\<PubHubLog>>>   | Retrieves all logs.                              |
| GetAllLogsOnFilter(user, _EntityID, _startdate, _EndDate, type)| user: ClaimsPrincipal, <br> _EntityID: Guid, <br> _startdate: DateTime, <br> _EndDate: DateTime, <br> type: LogType? | Task\<ServiceResponse\<List\<PubHubLog>>> | Retrieves logs based on a filter.                |
| GetAllLogsForAcquired(user)                   | user: ClaimsPrincipal                                                                          | Task\<ServiceResponse\<List\<PubHubLog>>>   | Retrieves all logs for acquired entities.        |
  
  ### Receipt Endpoints
  
| Service                                       | Parameters                                                                                      | Returns                                    | Description                                       |
|-----------------------------------------------|-------------------------------------------------------------------------------------------------|--------------------------------------------|---------------------------------------------------|
| GetNewestReceiptFromUser(_userID)             | _userID: Guid                                                                                  | Task\<ServiceResponse\<PubHubReceipt>>     | Retrieves the newest receipt for a user.         |
| GetTotalFromAcquired(_userID)                 | _userID: Guid                                                                                  | Task\<ServiceResponse\<double>>            | Retrieves the total from acquired items.         |
| GetReceiptByFilter(user, _EntityID, _AcuiredID, _startdate, _EndDate)| user: ClaimsPrincipal, <br> _EntityID: Guid, <br> _AcuiredID: Guid, <br> _startdate: DateTime, <br> _EndDate: DateTime | Task\<ServiceResponse\<List\<PubHubReceipt>>> | Retrieves receipts based on a filter.           |

  ### Other Services
| Service                            | Parameters                               | Returns                               | Description                                               |
|------------------------------------|------------------------------------------|---------------------------------------|-----------------------------------------------------------|
| SaveLog(_message, _logType, _EntiryID) | _message: string, <br> _logType: LogType = LogType.Information, <br> _EntiryID: Guid? | Task                                      | Saves a log with a message, log type, and optional entity ID. |
| FindUserAdminRights(_email, _username) | _email: string, <br> _username: string | Task\<ServiceResponse\<List\<ApplicationUser>>> | Finds user admin rights based on email and username.        |
| SaveBookReceipt(_Entiry, _Acquired) | _Entiry: Guid, <br> _Acquired: Guid | Task | Saves a book receipt with the provided entity and acquired IDs. |

</details>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## DB Diagram documentation
<details>
  <summary>Full DB Diagram</summary>
  <img src="https://github.com/LukasPedersen/PubHub/assets/61869988/4c603078-a103-42f9-9d34-9d019f62164a"></img>
</details>

<details>
  <summary>System DB Diagram</summary>
  <img src="https://github.com/LukasPedersen/PubHub/assets/61869988/36946620-69b9-4899-b44b-c0a52b45b999"></img>
</details>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->
## Contact

Your Name - [Lukas Pedersen](https://github.com/LukasPedersen) - lukas3302@hotmail.com

Project Link: [Jens Anker](https://github.com/ColdSwordX)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

Here is a list of resources we found helpful and would like to give credit to.


* [Font Awesome](https://fontawesome.com)
* [BootStrap icons](https://icons.getbootstrap.com/?q=log#install)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
