using System.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PubHubAPI;
using PubHubAPI.Data;
using PubHubAPI.Data.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Establish cookie authentication
builder.Services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();

// Configure app cookie
//
// The default values, which are appropriate for hosting the Backend and
// BlazorWasmAuth apps on the same domain, are Lax and SameAsRequest. 
// For more information on these settings, see:
// https://learn.microsoft.com/aspnet/core/blazor/security/webassembly/standalone-with-identity#cross-domain-hosting-same-site-configuration
/*
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.SameSite = SameSiteMode.Lax;
    options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
});
*/

// Configure authorization
builder.Services.AddAuthorizationBuilder();

// Add the database
builder.Services.AddDbContext<PubHubDBContext>(
options =>
{
    options.UseSqlServer(connectionString);
    //For debugging only: options.EnableDetailedErrors(true);
    //For debugging only: options.EnableSensitiveDataLogging(true);
});

// Add identity and opt-in to endpoints
builder.Services.AddIdentityCore<PubHubUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<PubHubDBContext>()
    .AddApiEndpoints();

// Add a CORS policy for the client
builder.Services.AddCors(
    options => options.AddPolicy(
        "wasm",
        policy => policy.WithOrigins(
            [builder.Configuration["BackendUrl"] ?? "https://n0gl8cjp-7174.euw.devtunnels.ms",
            builder.Configuration["FrontendUrl"] ?? "https://tbskfv4n-7016.euw.devtunnels.ms",
            ""])
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()));

// Add services to the container
builder.Services.AddEndpointsApiExplorer();

// Add NSwag services
builder.Services.AddOpenApiDocument();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (builder.Environment.IsDevelopment())
{

    // Add OpenAPI/Swagger generator and the Swagger UI
    app.UseOpenApi();
    app.UseSwagger();
    app.UseSwaggerUi();
}
// Create routes for the identity endpoints
app.MapIdentityApi<PubHubUser>();

// Activate the CORS policy
app.UseCors("wasm");

// Enable authentication and authorization after CORS Middleware
// processing (UseCors) in case the Authorization Middleware tries
// to initiate a challenge before the CORS Middleware has a chance
// to set the appropriate headers.
app.UseAuthentication();
app.UseAuthorization();

// Provide an end point to clear the cookie for logout
//
// For more information on the logout endpoint and antiforgery, see:
// https://learn.microsoft.com/aspnet/core/blazor/security/webassembly/standalone-with-identity#antiforgery-support
app.MapPost("/logout", async (SignInManager<PubHubUser> signInManager, [FromBody] object empty) =>
{
    if (empty is not null)
    {
        await signInManager.SignOutAsync();

        return Results.Ok();
    }

    return Results.Unauthorized();
}).RequireAuthorization();

app.UseHttpsRedirection();

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

app.Run();