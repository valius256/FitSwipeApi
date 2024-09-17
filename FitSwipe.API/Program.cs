using FitSwipe.API.Extensions;
using FitSwipe.API.Middleware;
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
builder.Services.Configure<VnPay>(builder.Configuration.GetSection("VnPay"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddDbContext<FitSwipeDbContext>(options =>
{
    options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5173") // Replace with your actual origin(s)
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});


// ADD Serviuces 
builder.Services.AddRepositories()
    .AddGeneralServices()
    .AddFireBaseServices(builder.Configuration)
    .AddHangFireConfigurations(builder.Configuration)
    .AddSwaggerWithConfigurations()
    .AddFirebaseAuthentication(builder.Configuration);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
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

app.UseCors();

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllers();
    endpoints.MapHangfireDashboard();
});


app.Run("http://0.0.0.0:5250");