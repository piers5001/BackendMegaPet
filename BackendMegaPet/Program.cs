using BackendMegaPet.Adopter.Domain.Repositories;
using BackendMegaPet.Adopter.Domain.Services;
using BackendMegaPet.Adopter.Persistence.Repositories;
using BackendMegaPet.Adopter.Services;
using BackendMegaPet.Shelter.Domain.Repositories;
using BackendMegaPet.Shelter.Domain.Services;
using BackendMegaPet.Shelter.Mapping;
using BackendMegaPet.Shelter.Persistence.Respositories;
using BackendMegaPet.Shelter.Services;
using BackendMegaPet.User.Domain.Repositories;
using BackendMegaPet.User.Domain.Services;
using BackendMegaPet.User.Mapping;
using BackendMegaPet.User.Persistence.Repositories;
using BackendMegaPet.User.Services;
using Microsoft.EntityFrameworkCore;
using ModelToResourceProfile = BackendMegaPet.Adopter.Mapping.ModelToResourceProfile;
using ResourceToModelProfile = BackendMegaPet.Adopter.Mapping.ResourceToModelProfile;
using UnitOfWork = BackendMegaPet.Shared.Persistence.Repositories.UnitOfWork;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<BackendMegaPet.Shared.Persistence.Contexts.AppDbContext>(
    options => options.UseMySQL(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

// Add Lowercase Routes

builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Dependency Injection Configuration

builder.Services.AddScoped<IAdopterRepository, AdopterRepository>();
builder.Services.AddScoped<IAdopterService, AdopterService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IShelterRepository, ShelterRepository>();
builder.Services.AddScoped<IShelterService, ShelterService>();

builder.Services.AddScoped<BackendMegaPet.Shared.Domain.Repositories.IUnitOfWork, UnitOfWork>();

// AutoMapper Configuration

builder.Services.AddAutoMapper(
    typeof(ModelToResourceProfile),
    typeof(ResourceToModelProfile));
    //typeof(ModelToResourceShelterProfile),
    //typeof(ResourceToModelShelterProfile));

    var app = builder.Build();

using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<BackendMegaPet.Shared.Persistence.Contexts.AppDbContext>())
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