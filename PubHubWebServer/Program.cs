using Blazored.Toast;
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

            builder.Services.AddBlazoredToast();

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
            //IRON PDF Free License KEY
            License.LicenseKey = "IRONSUITE.JENSNEERGAARD.HOTMAIL.COM.26630-85752B27F8-BAL5DW3-TWGHGKOQEP7A-TI6O53WFPWQ5-M4E3K6XUNHUH-SRMTWV5GFC5K-2PB4LXGAYKGS-LO4N4OFUWEEL-M4OYJD-TFSZ3JBS65WMEA-DEPLOYMENT.TRIAL-NO3QE4.TRIAL.EXPIRES.14.MAY.2024";
            app.Run();
        }
    }
}
