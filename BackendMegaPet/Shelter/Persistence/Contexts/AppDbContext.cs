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
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Shelter>().ToTable("Shelters");
        builder.Entity<Shelter>().HasKey(p => p.Id);
        builder.Entity<Shelter>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Shelter>().Property(p => p.address).IsRequired().HasMaxLength(50);
        builder.Entity<Shelter>().Property(p => p.image).IsRequired().HasMaxLength(50);
        builder.Entity<Shelter>().Property(p => p.phone).IsRequired();
        builder.Entity<Shelter>().Property(p => p.district).IsRequired().HasMaxLength(50);
        builder.Entity<Shelter>().Property(p => p.location).IsRequired().HasMaxLength(50);
        

        base.OnModelCreating(builder);
        
        builder.UseSnakeCaseNamingConvention();
    }

}