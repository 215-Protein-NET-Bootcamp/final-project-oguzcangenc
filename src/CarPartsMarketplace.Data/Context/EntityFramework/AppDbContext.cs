using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.Data.Context.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Color> Colors { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Offer> Offers { get; set; }
        DbSet<Product> Products { get; set; }

    }
}
