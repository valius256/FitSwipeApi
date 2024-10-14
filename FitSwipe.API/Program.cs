using FitSwipe.API.Extensions;
using FitSwipe.API.Middleware;
using FitSwipe.BusinessLogic.Library;
using FitSwipe.DataAccess.Model;
using Hangfire;
using Hangfire.Dashboard;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddLogging();

builder.Services.Configure<Appsettings>(builder.Configuration.GetSection("Appsettings"));

builder.Services.Configure<SmtpAppSetting>(builder.Configuration.GetSection("SmtpSettings"));
builder.Services.Configure<FirebaseUpload>(builder.Configuration.GetSection("FirebaseUpload"));

builder.Services.Configure<VnPay>(builder.Configuration.GetSection("VnPay"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddDbContext<FitSwipeDbContext>(options =>
{
    options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
    // using mssql
    // options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    //     b => b.MigrationsAssembly("FitSwipe.DataAccess"));

    // using postgres 
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresInLocal"),
        b => b.MigrationsAssembly("FitSwipe.DataAccess"));
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins() // Replace with your actual origin(s)
            .AllowAnyMethod()
            .AllowAnyHeader()
        .AllowCredentials();
    });
});


// ADD Serviuces 
#pragma warning disable CS0612 // Type or member is obsolete
builder.Services.AddRepositories()
                .AddGeneralServices()
                .AddFireBaseServices(builder.Configuration)
                .AddHangFireConfigurations(builder.Configuration)
                .AddSwaggerWithConfigurations()
                .AddFirebaseAuthentication(builder.Configuration);
#pragma warning restore CS0612 // Type or member is obsolete


// add signalR
builder.Services.AddSignalR();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseSwagger(options => { options.RouteTemplate = "openapi/{documentName}.json"; });
    //app.MapScalarApiReference();

}

using (var scope = app.Services.CreateScope())
{

    var dbContext = scope.ServiceProvider.GetRequiredService<FitSwipeDbContext>();

    try
    {
        dbContext.Database.Migrate();

        Console.WriteLine("Database migrations applied successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while applying migrations: {ex.Message}");
    }
}

app.UseHttpsRedirection();


// Configure Hangfire
app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    DashboardTitle = "Fit Swipe Dashboard",
    DarkModeEnabled = true,
    IsReadOnlyFunc = (DashboardContext context) => false,
    TimeZoneResolver = new DefaultTimeZoneResolver()
});

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseCors("AllowAllOrigins");
app.MapControllers();
app.MapHangfireDashboard();
app.MapHub<ChatHub>("/chathub");
//app.UseEndpoints(endpoints =>
//{

//    endpoints.MapControllers();
//    endpoints.MapHangfireDashboard();
//});

app.Run();