<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/LukasPedersen/PubHub">
    <img src="https://github.com/LukasPedersen/PubHub/assets/61869988/8d04f225-243b-415d-8749-9b0067861de4" alt="Logo" width="420" height="250">
  </a>

  <h3 align="center">Best-README-Template</h3>

  <p align="center">
    An awesome README template to jumpstart your projects!
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template">View Demo</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Report Bug</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Request Feature</a>
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
## API documentation
<details>
  <summary>Api Endpoints</summary>
  ### Generic EndPoints
  
  | Endpoint                   | Parameters              | Returns                  | Description                                  |
  |----------------------------|-------------------------|--------------------------|----------------------------------------------|
  | AddSingleEntity\<T>        | _entity: T              | ApiResponse\<string>     | Adds a single entity to the database.        |
  | AddMultipleEntities\<T>    | _entities: T            | ApiResponse\<string>     | Adds multiple entities to the database.      |
  | UpdateEntity\<T>           | _entity: T              | ApiResponse\<string>     | Updates a single entity in the database.     |
  | UpdateMultipleEntities\<T> | _entities: T            | ApiResponse\<string>     | Updates multiple entities in the database.   |
  | GetEntityByID\<T>          | _entityID: Guid         | ApiResponse\<T>          | Retrieves an entity by its ID.               |
  | DeleteEntity\<T>           | _entity: T              | ApiResponse\<string>     | Deletes a single entity from the database.   |
  | DeleteMultipleEntities\<T> | _entity: T              | ApiResponse\<string>     | Deletes multiple entities from the database. |
  
  ### User Endpoints
  
  | Endpoint           | Parameters       | Returns                  | Description                             |
  |--------------------|------------------|--------------------------|-----------------------------------------|
  | GetUserRoles       | _userID: string  | ApiResponse\<IdentityRole> | Retrieves roles associated with a user. |
  | DeactivateUser     | _userID: string  | ApiResponse\<string>      | Deactivates a user.                     |
  
  ### Publisher Endpoints
  
  | Endpoint                        | Parameters           | Returns                           | Description                                   |
  |---------------------------------|----------------------|-----------------------------------|-----------------------------------------------|
  | GetAllPublishersSubscriptions   | _readerID: Guid      | ApiResponse\<List\<PubHubSubscription>> | Retrieves all subscriptions for a publisher. |
  | GetAllPublishersBooks           | _readerID: Guid      | ApiResponse\<List\<PubHubEBook>>        | Retrieves all books published by a publisher.|
  | GetTotalEarnings                | _userID: Guid        | ApiResponse\<double>                | Retrieves the total earnings for a user.    |
  
  ### Reader Endpoints
  
  | Endpoint                     | Parameters           | Returns                          | Description                               |
  |------------------------------|----------------------|----------------------------------|-------------------------------------------|
  | GetAllReadersSubscriptions   | _readerID: Guid      | ApiResponse\<List\<PubHubSubscription>> | Retrieves all subscriptions for a reader. |
  | GetAllReadersBooks           | _readerID: Guid      | ApiResponse\<List\<PubHubEBook>>        | Retrieves all books read by a reader.     |
  | GetTotalSpendings            | _userID: Guid        | ApiResponse\<double>                | Retrieves the total spendings for a user.|
  
  ### Subscription Endpoints
  
  | Endpoint                          | Parameters                | Returns                             | Description                                 |
  |-----------------------------------|---------------------------|-------------------------------------|---------------------------------------------|
  | AddBookToSubscription             | _bookID: Guid, _subscriptionID: Guid | ApiResponse\<string>           | Adds a book to a subscription.                |
  | RemoveBookFromSubscription        | _bookID: Guid, _subscriptionID: Guid | ApiResponse\<string>           | Removes a book from a subscription.           |
  | GetAllBooksFromSubscription      | _subscriptionID: Guid    | ApiResponse\<List\<PubHubEBook>>      | Retrieves all books from a subscription.      |
  | GetTotalErningsFromSubscription  | _subscriptionID: Guid    | ApiResponse\<double>                  | Retrieves the total earnings from a subscription.|
  
  ### Ebook Endpoints
  
  | Endpoint                        | Parameters               | Returns                          | Description                                   |
  |---------------------------------|--------------------------|----------------------------------|-----------------------------------------------|
  | GetAllBooksFromUserByID         | _userID: string          | ApiResponse\<List\<PubHubEBook>> | Retrieves all books associated with a user.  |
  | GetAllEarningsFromBookByID      | _bookID: Guid            | ApiResponse\<double>              | Retrieves the total earnings from a specific book.|
  
  ### Logs Endpoints
  
  | Endpoint                       | Parameters                | Returns                           | Description                                 |
  |--------------------------------|---------------------------|-----------------------------------|---------------------------------------------|
  | GetLogByID                     | _logID: Guid              | ApiResponse\<PubHubLog>           | Retrieves a log entry by its ID.            |
  | GetAllLogs                     |                           | ApiResponse\<List\<PubHubLog>>    | Retrieves all log entries.                  |
  | GetAllLogsOnEntityByID         | _EntityID: Guid           | ApiResponse\<List\<PubHubLog>>    | Retrieves all log entries for a specific entity.|
  | GetAllLogsForAcquired          |                           | ApiResponse\<List\<PubHubLog>>    | Retrieves all log entries for acquired entities.|
  
  ### Receipt Endpoints
  
  | Endpoint                            | Parameters                 | Returns                             | Description                                   |
  |-------------------------------------|----------------------------|-------------------------------------|-----------------------------------------------|
  | GetNewestReceiptFromUser            | _userID: Guid              | ApiResponse\<PubHubReceipt>         | Retrieves the newest receipt associated with a user.|
  | GetTotalFromAcquired                | _userID: Guid              | ApiResponse\<double>                | Retrieves the total from acquired entities for a user.|
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

Your Name - [@your_twitter](https://twitter.com/your_username) - email@example.com

Project Link: [https://github.com/your_username/repo_name](https://github.com/your_username/repo_name)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

Here is a list of resources we found helpful and would like to give credit to.


* [GitHub Pages](https://pages.github.com)
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
