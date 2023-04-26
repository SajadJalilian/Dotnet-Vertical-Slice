using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
}