using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Radzen;
using SIB.Server.Client.Pages;
using SIB.Server.Components;
using SIB.Server.Components.Account;
using SIB.Server.Data;
using SIB.Server.Plugins;
using SIB.Server.UseCases;
using SIB.Server.UseCases.Interfaces;
using SIB.Server.UseCases.PluginInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddTransient<ApplicationDbContext, ApplicationDbContext>();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();
//�����������
builder.Services.AddTransient<IArticleRepository, ArticleRepository>();
builder.Services.AddTransient<ITagsRepository, TagsRepository>();

//Use Cases
builder.Services.AddTransient<IAddArticleUseCase, AddArticleUseCase>();
builder.Services.AddTransient<IGetAllArticlesUseCase, GetAllArticlesUseCase>();
builder.Services.AddTransient<IGetAllTagsUseCase, GetAllTagsUseCase>();

builder.Services.AddRadzenComponents();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("OwnerPolicy", policy => policy.RequireRole("Owner"));
    options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin","Owner"));
    options.AddPolicy("ModeratorPolicy", policy => policy.RequireRole("Moderator", "Admin", "Owner"));
    options.AddPolicy("CreatorPolicy", policy => policy.RequireRole("Creator", "Moderator","Admin", "Owner"));
});

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Counter).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
