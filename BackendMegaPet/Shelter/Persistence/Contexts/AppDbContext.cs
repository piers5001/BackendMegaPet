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

        builder.Entity<Shelter>().ToTable("shelters");
        builder.Entity<Shelter>().HasKey(p => p.Id);
        builder.Entity<Shelter>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Shelter>().Property(p => p.address).IsRequired();
        builder.Entity<Shelter>().Property(p => p.image).IsRequired();
        builder.Entity<Shelter>().Property(p => p.phone).IsRequired();
        builder.Entity<Shelter>().Property(p => p.district).IsRequired();
        builder.Entity<Shelter>().Property(p => p.location).IsRequired();
        
        
        builder.UseSnakeCaseNamingConvention();
    }

}