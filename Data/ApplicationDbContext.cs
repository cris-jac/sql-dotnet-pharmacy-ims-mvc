using Microsoft.EntityFrameworkCore;
using PharmaMVC.Models;

namespace PharmaMVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Subcategory> Subcategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SalesBasket> SalesBaskets { get; set; }
    public DbSet<SalesItem> SalesItems { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}