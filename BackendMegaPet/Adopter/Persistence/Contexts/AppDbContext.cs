using BackendMegaPet.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.Adopter.Persistence.Contexts;
using BackendMegaPet.Adopter.Domain.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Adopter> Adopters { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Adopter>().ToTable("Adopters");
        builder.Entity<Adopter>().HasKey(p => p.Id);
        builder.Entity<Adopter>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Adopter>().Property(p => p.name).IsRequired().HasMaxLength(10);
        builder.Entity<Adopter>().Property(p => p.lastname).IsRequired().HasMaxLength(10);
        builder.Entity<Adopter>().Property(p => p.gender).IsRequired();
        builder.Entity<Adopter>().Property(p => p.age).IsRequired();
        builder.Entity<Adopter>().Property(p => p.status).IsRequired();
        builder.Entity<Adopter>().Property(p => p.description).IsRequired();


        
        
        builder.UseSnakeCaseNamingConvention();
    }
}