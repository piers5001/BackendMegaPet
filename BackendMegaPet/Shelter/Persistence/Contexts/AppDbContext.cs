using AutoMapper;
using BackendMegaPet.Shared.Extensions;
using Microsoft.EntityFrameworkCore;
namespace BackendMegaPet.Shelter.Persistence.Contexts;
using BackendMegaPet.Shelter.Domain.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Shelter> Shelters { get; set; }
    //public DbSet<Pet> Pets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Shelter>().ToTable("Shelters");
        builder.Entity<Shelter>().HasKey(p => p.Id);
        builder.Entity<Shelter>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Shelter>().Property(p => p.address).IsRequired().HasMaxLength(10);
        builder.Entity<Shelter>().Property(p => p.image).IsRequired().HasMaxLength(120);
        builder.Entity<Shelter>().Property(p => p.phone).IsRequired().HasMaxLength(10);
        builder.Entity<Shelter>().Property(p => p.district).IsRequired().HasMaxLength(100);
        builder.Entity<Shelter>().Property(p => p.location).IsRequired().HasMaxLength(100);
        //builder.Entity<User>()
        //    .HasMany(p => p.Pets)
        //    .WithOne(p => p.User)
        //    .HasForeignKey(p => p.UserId);
        
        builder.UseSnakeCaseNamingConvention();
    }

}