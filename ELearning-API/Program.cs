using ELearning.Utility;
using ELearning_API;
using ELearning_API.Data;
using ELearning_API.Data.Repositories;
using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.Extensions;
using ELearning_API.Models;
using ELearning_API.Profiles;
using ELearning_API.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using NLog;
using NLog.Extensions.Logging;

var logger = LogManager.GetCurrentClassLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);


    builder.Services.AddLogging(loggingBuilder => {

        loggingBuilder.ClearProviders();
        loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
        loggingBuilder.AddNLog();
    });

    // Add services to the container.
    builder.Services.RegisterMapsterConfiguration();

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Add Database Context
    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });


    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                ValidateLifetime = true,
                ValidIssuer = builder.Configuration["AppSettings:AuthSettings:Issuer"],
                ValidAudience = builder.Configuration["AppSettings:AuthSettings:Audience"],

                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["AppSettings:AuthSettings:SecretKey"]!)),
                ClockSkew = TimeSpan.Zero,
            };
        });

    // Add Identity
    builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
    {
        options.User.RequireUniqueEmail = true;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
    })
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();

    builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
    {
        int refreshTokenExpirationMinutes = int.Parse(builder.Configuration["AppSettings:AuthSettings:RefreshTokenExpiration"]!);
        options.TokenLifespan = TimeSpan.FromMinutes(refreshTokenExpirationMinutes);
    });

    // User Defined Services
    builder.Services.AddTransient<IJWTService, JWTService>();
    builder.Services.AddTransient<IUsersService, UsersService>();
    builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    builder.Services.AddTransient<IAccountService, AccountService>();
    builder.Services.AddScoped<IEmailSender, EmailSender>();

    builder.Services.AddAppConfiguration();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

catch(Exception ex)
{
    // NLog: catch any exception and log it.
    logger.Error(ex, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    LogManager.Shutdown();
}
