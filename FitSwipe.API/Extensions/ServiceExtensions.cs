using FirebaseAdmin;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Chats;
using FitSwipe.BusinessLogic.Interfaces.Payments;
using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.BusinessLogic.Interfaces.Slots;
using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.BusinessLogic.Interfaces.Trainings;
using FitSwipe.BusinessLogic.Interfaces.Transactions;
using FitSwipe.BusinessLogic.Interfaces.UploadDowload;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.BusinessLogic.Services.Auths;
using FitSwipe.BusinessLogic.Services.Chats;
using FitSwipe.BusinessLogic.Services.Payments;
using FitSwipe.BusinessLogic.Services.Sender;
using FitSwipe.BusinessLogic.Services.Slots;
using FitSwipe.BusinessLogic.Services.Tags;
using FitSwipe.BusinessLogic.Services.Trainings;
using FitSwipe.BusinessLogic.Services.Transactions;
using FitSwipe.BusinessLogic.Services.UploadDowload;
using FitSwipe.BusinessLogic.Services.Users;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Repository;
using FitSwipe.DataAccess.Repository.Impl;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.SchedulerJobs;
using FitSwipe.Shared.Enum;
using Google.Apis.Auth.OAuth2;
using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Configuration;

namespace FitSwipe.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserTagRepository, UserTagRepository>();
            services.AddScoped<ISlotRepository, SlotRepository>();
            services.AddScoped<ITrainingRepository, TrainingRepository>();
            services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();
            services.AddScoped<ITrainingRepository, TrainingRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ISlotVideoRepository, SlotVideoRepository>();
            services.AddScoped<IFeedbackImageRepository, FeedbackImageRepository>();
            services.AddScoped<IChatRoomRepository, ChatRoomRepository>();
            services.AddScoped<IUserChatRoomRepository, UserChatRoomRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<ISlotTransactionRepository, SlotTransactionRepository>();
            services.AddScoped<IUserMediaRepository, UserMediaRepository>();
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
            services.AddScoped<IFirebaseUploadDowloadServices, FirebaseUploadDowloadServices>();
            services.AddScoped<IPaymentServices, PaymentServices>();
            services.AddScoped<ISlotServices, SlotServices>();
            services.AddScoped<ITransactionServices, TransactionServices>();
            services.AddScoped<ISlotVideoServices, SlotVideoServices>();
            services.AddScoped<IFirebaseUploadDowloadServices, FirebaseUploadDowloadServices>();
            services.AddScoped<ITrainingService, TrainingService>();
            services.AddScoped<IFeedbackImageSevices, FeedbackImageSevices>();
            services.AddScoped<IChatServices, ChatServices>();
            services.AddScoped<ISlotTransactionServices, SlotTransactionServices>();
            services.AddScoped<IUserMediaService, UserMediaService>();

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
                ProjectId = firebaseSettings?.ProjectId,
            });

            //var storageClient = StorageClient.Create(GoogleCredential.FromFile(firebaseJsonPath));


            return services;
        }

        [Obsolete]
        public static IServiceCollection AddHangFireConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            // Register Hangfire and configure it
            services.AddHangfire(config =>

                config.UsePostgreSqlStorage(configuration.GetConnectionString("PostgresConnectionString"),
                    new PostgreSqlStorageOptions
                    {
                        QueuePollInterval = TimeSpan.FromSeconds(15), // Adjust the poll interval as needed
                        PrepareSchemaIfNecessary = true
                    })
            );

            // Register Hangfire server
            services.AddHangfireServer();

            // Register any other required services here
            services.AddTransient<IDefaultScheduleJob, DefaultScheduleJob>();



            return services;
        }

        public static IServiceCollection AddSwaggerWithConfigurations(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Fit Swipe API V1", Version = "V1.0" });

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description =
                        @"JWT Authorization header using the Bearer scheme. Enter 'Bearer' [space] and then your token in the text input below. Example: 'Bearer 12345example'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>(); // Handles the authorization button
            });

            return services;
        }

        public static IServiceCollection AddFirebaseAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var firebaseSettings = configuration.GetSection(nameof(Appsettings.FireBase)).Get<FireBase>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    if (firebaseSettings is null)
                    {
                        throw new SettingsPropertyNotFoundException("Firebase settings not found");
                    }
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
