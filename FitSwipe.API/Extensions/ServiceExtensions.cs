using FirebaseAdmin;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.User;
using FitSwipe.BusinessLogic.Services.Auth;
using FitSwipe.BusinessLogic.Services.User;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Repository;
using FitSwipe.DataAccess.Repository.Impl;
using FitSwipe.DataAccess.Repository.Intefaces;
using Google.Apis.Auth.OAuth2;

namespace FitSwipe.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

            services.AddProblemDetails();
            services.AddLogging();

            return services;
        }

        public static IServiceCollection AddGeneralServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();

            services.AddScoped<IFirebaseAuthServices, FirebaseAuthServices>();


            //services.AddTransient<IEmailServices, EmailServices>();
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
                    ProjectId = firebaseSettings.ProjectId
                });
            }
            return services;
        }

    }
}
