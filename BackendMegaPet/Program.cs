using BackendMegaPet.Shelter.Domain.Repositories;
using BackendMegaPet.Shelter.Domain.Services;
using BackendMegaPet.Shelter.Mapping;
using BackendMegaPet.Shelter.Persistence.Respositories;
using BackendMegaPet.Shelter.Services;
using Microsoft.EntityFrameworkCore;
using AppDbContext = BackendMegaPet.Shelter.Persistence.Contexts.AppDbContext;
//using IUnitOfWork = BackendMegaPet.User.Domain.Repositories.IUnitOfWork;
//using UnitOfWork = BackendMegaPet.User.Persistence.Repositories.UnitOfWork;

using IUnitOfWork = BackendMegaPet.Shelter.Domain.Repositories.IUnitOfWork;
using UnitOfWork = BackendMegaPet.Shelter.Persistence.Respositories.UnitOfWork;

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

//builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IShelterRepository, ShelterRepository>();
builder.Services.AddScoped<IShelterService, ShelterService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// AutoMapper Configuration

builder.Services.AddAutoMapper(
    //typeof(ModelToResourceProfile),
    //typeof(ResourceToModelProfile));
    typeof(ModelToResourceShelterProfile),
    typeof(ResourceToModelShelterProfile));

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