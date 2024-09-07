using FitSwipe.API.Extensions;
using FitSwipe.API.Middleware;
using FitSwipe.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddLogging();

builder.Services.Configure<Appsettings>(builder.Configuration.GetSection("Appsettings"));


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


// ADD CORS
builder.Services.AddCors(options => options.AddDefaultPolicy(policyBuilder =>
    policyBuilder.WithOrigins("http://localhost:5173") // replace with your domain when mobile done
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()));

// ADD Serviuces 
builder.Services.AddRepositories()
    .AddGeneralServices()
    .AddFireBaseServices(builder.Configuration)
    
    ;


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
