using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.Shared.Persistence.Contexts;
using BackendMegaPet.User.Domain.Models;
using BackendMegaPet.Adopter.Domain.Models;
using BackendMegaPet.Shelter.Domain.Models;
using BackendMegaPet.Pet.Domain.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Adopter> Adopters { get; set; }
    public DbSet<Shelter> Shelters { get; set; }
    
    public DbSet<Pet> Pets { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<User>().ToTable("Users");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(p => p.name).IsRequired().HasMaxLength(10);
        builder.Entity<User>().Property(p => p.lastName).IsRequired().HasMaxLength(10);
        builder.Entity<User>().Property(p => p.phone).IsRequired();
        builder.Entity<User>().Property(p => p.image).IsRequired().HasMaxLength(50);
        builder.Entity<User>().Property(p => p.email).IsRequired().HasMaxLength(20);
        builder.Entity<User>().Property(p => p.password).IsRequired().HasMaxLength(15);
        builder.Entity<User>().Property(p => p.birthday).IsRequired();
        
        builder.Entity<Adopter>().ToTable("Adopters");
        builder.Entity<Adopter>().HasKey(p => p.Id);
        builder.Entity<Adopter>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Adopter>().Property(p => p.name).IsRequired().HasMaxLength(10);
        builder.Entity<Adopter>().Property(p => p.lastname).IsRequired().HasMaxLength(10);
        builder.Entity<Adopter>().Property(p => p.gender).IsRequired();
        builder.Entity<Adopter>().Property(p => p.age).IsRequired();
        builder.Entity<Adopter>().Property(p => p.status).IsRequired();
        builder.Entity<Adopter>().Property(p => p.description).IsRequired();
        
        builder.Entity<Shelter>().ToTable("Shelters");
        builder.Entity<Shelter>().HasKey(p => p.Id);
        builder.Entity<Shelter>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Shelter>().Property(p => p.address).IsRequired().HasMaxLength(50);
        builder.Entity<Shelter>().Property(p => p.image).IsRequired().HasMaxLength(50);
        builder.Entity<Shelter>().Property(p => p.phone).IsRequired();
        builder.Entity<Shelter>().Property(p => p.district).IsRequired().HasMaxLength(50);
        builder.Entity<Shelter>().Property(p => p.location).IsRequired().HasMaxLength(50);
        
        builder.Entity<Pet>().ToTable("Pets");
        builder.Entity<Pet>().HasKey(p => p.id);
        builder.Entity<Pet>().Property(p => p.id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Pet>().Property(p => p.name).IsRequired().HasMaxLength(50);
        builder.Entity<Pet>().Property(p => p.description).IsRequired().HasMaxLength(150);
        builder.Entity<Pet>().Property(p => p.image).IsRequired().HasMaxLength(50);
        builder.Entity<Pet>().Property(p => p.rescuedTime).IsRequired();
        builder.Entity<Pet>().Property(p => p.category).IsRequired().HasMaxLength(50);
        builder.Entity<Pet>().Property(p => p.inventoryStatus).IsRequired().HasMaxLength(50);
        builder.Entity<Pet>().Property(p => p.rating).IsRequired();
    }

}