using BackendMegaPet.Adopter.Domain.Repositories;
using BackendMegaPet.Adopter.Domain.Services;
using BackendMegaPet.Adopter.Persistence.Repositories;
using BackendMegaPet.Adopter.Services;
using BackendMegaPet.User.Domain.Services;
using BackendMegaPet.User.Mapping;
using BackendMegaPet.Adopter.Persistence.Contexts;
using BackendMegaPet.User.Persistence.Repositories;
using BackendMegaPet.User.Services;
using Microsoft.EntityFrameworkCore;
using IUnitOfWork = BackendMegaPet.User.Domain.Repositories.IUnitOfWork;
using UnitOfWork = BackendMegaPet.User.Persistence.Repositories.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

// Add Lowercase Routes

builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Dependency Injection Configuration



builder.Services.AddScoped<IAdopterRepository, AdopterRepository>();
builder.Services.AddScoped<IAdopterService, AdopterService>();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// AutoMapper Configuration

builder.Services.AddAutoMapper(
    typeof(ModelToResourceProfile),
    typeof(ResourceToModelProfile));


var app = builder.Build();

using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<AppDbContext>())
{
    context.Database.EnsureCreated();
}


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