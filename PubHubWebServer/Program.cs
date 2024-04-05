using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PubHubWebServer.Components;
using PubHubWebServer.Components.Account;
using PubHubWebServer.Data;
using PubHubWebServer.Data.Models;
using PubHubWebServer.Services;
using System.Security.Claims;

namespace PubHubWebServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IPubHubServices, PubHubServices>();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddScoped<IdentityUserAccessor>();
            builder.Services.AddScoped<IdentityRedirectManager>();
            builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

            builder.Services.AddAuthentication(options =>
                {
                    options.DefaultScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                })
                .AddIdentityCookies();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<PubHubDBContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<PubHubDBContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders()
                .AddApiEndpoints();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

            builder.Services.AddOpenApiDocument();
            builder.Services.AddSwaggerGen();

            builder.Services.AddHttpClient();//Added HttpClient as a service
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseSwaggerUi();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.MapIdentityApi<ApplicationUser>();
            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            // Add additional endpoints required by the Identity /Account Razor components.
            app.MapAdditionalIdentityEndpoints();

            #region User Endpoints

            app.MapGet("/roles", (ClaimsPrincipal user) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var identity = (ClaimsIdentity)user.Identity;
                    var roles = identity.FindAll(identity.RoleClaimType)
                        .Select(c =>
                            new
                            {
                                c.Issuer,
                                c.OriginalIssuer,
                                c.Type,
                                c.Value,
                                c.ValueType
                            });

                    return TypedResults.Json(roles);
                }

                return Results.Unauthorized();
            }).RequireAuthorization();

            app.MapGet("user/deactivateUser/{userID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, string userID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeactivateUser(userID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("users").RequireAuthorization();

            #endregion

            #region Publisher Endpoints

            app.MapGet("publisher/getAllPublishersSubscriptions/{publisherID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid publisherID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllPublishersSubscriptions(publisherID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("publishers").RequireAuthorization();

            app.MapGet("publisher/getAllPublishersBooks/{publisherID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid publisherID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllPublishersBooks(publisherID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("publishers").RequireAuthorization();

            app.MapGet("publisher/getTotalEarnings/{userID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid userID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetTotalEarnings(userID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("publishers").RequireAuthorization();

            #endregion

            #region Reader Endpoints

            app.MapGet("reader/getAllReadersSubscriptions/{readerID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid readerID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllReadersSubscriptions(readerID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("readers").RequireAuthorization();

            app.MapGet("reader/getAllReadersBooks/{readerID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid readerID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllReadersBooks(readerID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("readers").RequireAuthorization();

            app.MapGet("reader/getTotalSpendings/{userID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid userID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetTotalSpendings(userID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("readers").RequireAuthorization();

            #endregion

            #region Subscription Endpoints

            app.MapPost("subscription/createSubscription", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubSubscription subscription) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddSingleEntity(subscription);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapPost("subscription/createSubscriptions", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubSubscription> subscriptions) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddMultipleEntities(subscriptions);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapPut("subscription/updateSubscription", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubSubscription subscription) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateEntity(subscription);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapPut("subscription/updateSubscriptions", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubSubscription> subscriptions) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateMultipleEntities(subscriptions);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapGet("subscription/getSubscription/{entityID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid entityID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetEntityByID<PubHubSubscription>(entityID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapDelete("subscription/deleteSubscription", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubSubscription subscription) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteEntity(subscription);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapDelete("subscription/deleteSubscriptions", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubSubscription> subscriptions) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteMultipleEntities(subscriptions);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapPost("subscription/addBookToSubscription", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid bookId, Guid subscriptionId) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddBookToSubscription(bookId, subscriptionId);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapPost("subscription/removeBookFromSubscription", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid bookId, Guid subscriptionId) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.RemoveBookFromSubscription(bookId, subscriptionId);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapGet("subscription/getAllBooksFromSubscription/{subscriptionID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid subscriptionId) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllBooksFromSubscription(subscriptionId);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            app.MapGet("subscription/getTotalEarningsFromSubscription/{subscriptionID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid subscriptionId) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetTotalErningsFromSubscription(subscriptionId);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("subscriptions").RequireAuthorization();

            #endregion

            #region Ebook Endpoints

            app.MapPost("ebook/createEbook", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubEBook ebook) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddSingleEntity(ebook);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapPost("ebook/createEbooks", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubEBook> ebooks) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddMultipleEntities(ebooks);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapPut("ebook/updateEbook", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubEBook ebook) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateEntity(ebook);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapPut("ebook/updateEbooks", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubEBook> ebooks) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateMultipleEntities(ebooks);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapGet("ebook/getEbook/{entityID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid entityID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetEntityByID<PubHubEBook>(entityID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapDelete("ebook/deleteEbook", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubEBook ebook) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteEntity(ebook);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapDelete("ebook/deleteEbooks", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubEBook> ebooks) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteMultipleEntities(ebooks);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapGet("user/getAllBooksFromUser/{userID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, string userId) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllBooksFromUserByID(userId);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            app.MapGet("book/getAllEarnings/{bookID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid bookId) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllEarningsFromBookByID(bookId);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("ebooks").RequireAuthorization();

            #endregion

            #region Logs Endpoints

            app.MapPost("log/createLog", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubLog log) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddSingleEntity(log);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapPost("log/createLogs", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubLog> logs) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddMultipleEntities(logs);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapPut("log/updateLog", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubLog log) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateEntity(log);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapPut("log/updateLogs", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubLog> logs) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateMultipleEntities(logs);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapGet("log/getLog/{entityID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid entityID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetEntityByID<PubHubLog>(entityID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapDelete("log/deleteLog", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubLog log) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteEntity(log);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapDelete("log/deleteLogs", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubLog> logs) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteMultipleEntities(logs);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapGet("log/getAllLogs", async (ClaimsPrincipal user, IPubHubServices pubHubServices) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllLogs();
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapGet("log/getAllLogsOnEntity/{entityID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid entityID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllLogsOnEntityByID(entityID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            app.MapGet("log/getAllLogsForAcquired", async (ClaimsPrincipal user, IPubHubServices pubHubServices) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetAllLogsForAcquired();
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("logs").RequireAuthorization();

            #endregion

            #region Receipt Endpoints

            app.MapPost("receipt/createReceipt", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubReceipt receipt) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddSingleEntity(receipt);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapPost("receipt/createReceipts", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubReceipt> receipts) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.AddMultipleEntities(receipts);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapPut("receipt/updateReceipt", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubReceipt receipt) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateEntity(receipt);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapPut("receipt/updateReceipts", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubReceipt> receipts) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.UpdateMultipleEntities(receipts);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapGet("receipt/getReceipt/{entityID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid entityID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetEntityByID<PubHubReceipt>(entityID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapDelete("receipt/deleteReceipt", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] PubHubReceipt receipt) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteEntity(receipt);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapDelete("receipt/deleteReceipts", async (ClaimsPrincipal user, IPubHubServices pubHubServices, [FromBody] List<PubHubReceipt> receipts) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.DeleteMultipleEntities(receipts);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapGet("receipt/getNewestReceipt/{userID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid userID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetNewestReceiptFromUser(userID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            app.MapGet("receipt/getTotalFromAcquired/{userID}", async (ClaimsPrincipal user, IPubHubServices pubHubServices, Guid userID) =>
            {
                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var response = await pubHubServices.GetTotalFromAcquired(userID);
                    return Results.Json(response);
                }

                return Results.Unauthorized();
            }).WithTags("receipts").RequireAuthorization();

            #endregion

            app.Run();
        }
    }
}
