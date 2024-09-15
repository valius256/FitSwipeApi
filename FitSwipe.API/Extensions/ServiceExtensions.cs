using FirebaseAdmin;
using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.BusinessLogic.Services.Auth;
using FitSwipe.BusinessLogic.Services.Sender;
using FitSwipe.BusinessLogic.Services.Tags;
using FitSwipe.BusinessLogic.Services.Users;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Repository;
using FitSwipe.DataAccess.Repository.Impl;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.SchedulerJobs;
using Google.Apis.Auth.OAuth2;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace FitSwipe.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserTagRepository, UserTagRepository>();
            services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();
            services.AddProblemDetails();
            services.AddLogging();

            return services;
        }

        public static IServiceCollection AddGeneralServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IUserTagService, UserTagService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IFirebaseAuthServices, FirebaseAuthServices>();


            services.AddTransient<IEmailServices, EmailServices>();
            //services.AddTransient<IJwtProviderServices, JwtProviderServices>();
            services.AddProblemDetails();
            services.AddLogging();
            return services;
        }

        public static IServiceCollection AddFireBaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            var firebaseSettings = configuration.GetSection(nameof(Appsettings.FireBase)).Get<FireBase>();
            var firebaseJsonPath = Path.Combine(Directory.GetCurrentDirectory(), "fit-swipe-firebase-config.json");
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions
                {
                    Credential = GoogleCredential.FromFile(firebaseJsonPath),
                    ProjectId = firebaseSettings?.ProjectId
                });
            }
            return services;
        }

        public static IServiceCollection AddHangFireConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            // Register Hangfire and configure it
            services.AddHangfire(config =>

                config.UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"),
                    new SqlServerStorageOptions
                    {
                        TryAutoDetectSchemaDependentOptions = false,
                        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                        QueuePollInterval = TimeSpan.Zero,
                        UseRecommendedIsolationLevel = true,
                        DisableGlobalLocks = true
                    })
            );

            // Register Hangfire server
            services.AddHangfireServer();

            // Register any other required services here
            services.AddTransient<IDefaultScheduleJob, DefaultScheduleJob>();



            return services;
        }

        public static IServiceCollection AddFirebaseAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var firebaseSettings = configuration.GetSection(nameof(Appsettings.FireBase)).Get<FireBase>();
            // Add Authentication with JWT Bearer
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = $"https://securetoken.google.com/{firebaseSettings.ProjectId}",
                        ValidateAudience = true,
                        ValidAudience = firebaseSettings.ProjectId,
                        ValidateLifetime = true
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                            context.Token = token;
                            return Task.CompletedTask;
                        },
                        OnTokenValidated = async context =>
                        {
                            var token = context.SecurityToken as JwtSecurityToken;
                            if (token != null)
                            {
                                var firebaseToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token.RawData);
                                var uid = firebaseToken.Uid; // Firebase user ID

                                // You can add custom claims here if necessary
                                context.HttpContext.User.AddIdentity(new System.Security.Claims.ClaimsIdentity(new[]
                                {
                                new System.Security.Claims.Claim("uid", uid),
                                }));
                            }
                        }
                    };
                });

            // Add Authorization Policy (optional, if you want to define roles)
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy => policy.RequireClaim("role", "admin"));
            });

            return services;
        }

    }
}
