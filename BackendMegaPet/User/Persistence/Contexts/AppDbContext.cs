using BackendMegaPet.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.User.Persistence.Contexts;
using BackendMegaPet.User.Domain.Models;
using BackendMegaPet.Pet.Domain.Models;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Pet> Pets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().ToTable("Categories");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(p => p.name).IsRequired().HasMaxLength(10);
        builder.Entity<User>().Property(p => p.lastName).IsRequired().HasMaxLength(10);
        builder.Entity<User>().Property(p => p.phone).IsRequired().HasMaxLength(10);
        builder.Entity<User>().Property(p => p.image).IsRequired().HasMaxLength(50);
        builder.Entity<User>().Property(p => p.email).IsRequired().HasMaxLength(20);
        builder.Entity<User>().Property(p => p.password).IsRequired().HasMaxLength(15);
        builder.Entity<User>().Property(p => p.birthday).IsRequired().HasMaxLength(10);

        builder.Entity<User>()
            .HasMany(p => p.Pets)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
        
        
        
        builder.UseSnakeCaseNamingConvention();
    }
}