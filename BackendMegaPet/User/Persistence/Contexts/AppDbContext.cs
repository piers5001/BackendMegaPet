using BackendMegaPet.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BackendMegaPet.User.Persistence.Contexts;
using BackendMegaPet.User.Domain.Models;
using BackendMegaPet.Shelter.Domain.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

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

        base.OnModelCreating(builder);
    }
}