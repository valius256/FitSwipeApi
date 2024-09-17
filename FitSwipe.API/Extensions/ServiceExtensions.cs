using FirebaseAdmin;
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
using FitSwipe.Shared.Enum;
using Google.Apis.Auth.OAuth2;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

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
            ;

            services.AddTransient<IEmailServices, EmailServices>();
            services.AddScoped<IJwtProviderServices, JwtProviderServices>();
            services.AddProblemDetails();
            services.AddLogging();
            return services;
        }

        public static IServiceCollection AddFireBaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            var firebaseSettings = configuration.GetSection(nameof(Appsettings.FireBase)).Get<FireBase>();
            var firebaseJsonPath = Path.Combine(Directory.GetCurrentDirectory(), "fit-swipe-161d7-firebase-adminsdk-l0tth-9884dc9fa1.json");
            FirebaseApp.Create(new AppOptions
            {
                Credential = GoogleCredential.FromFile(firebaseJsonPath),
                ProjectId = firebaseSettings?.ProjectId
            });
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

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = $"https://session.firebase.google.com/{firebaseSettings.ProjectId}";

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = $"https://session.firebase.google.com/{firebaseSettings.ProjectId}",
                        ValidateAudience = true,
                        ValidAudience = firebaseSettings.ProjectId,
                        ValidateLifetime = true,

                    };


                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireTraineeRole", policy => policy.RequireRole(Role.Trainee.ToString()));
                options.AddPolicy("RequirePTRole", policy => policy.RequireRole(Role.PT.ToString()));
                options.AddPolicy("RequireOperatorRole", policy => policy.RequireRole(Role.Operator.ToString()));
            });

            return services;
        }


    }
}
