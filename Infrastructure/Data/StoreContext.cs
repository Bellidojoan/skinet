using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data

{
    public class StoreContext : DbContext
    {
        
        public StoreContext(DbContextOptions<StoreContext> options) : base (options)
        {
            
        }

        public DbSet<Product> Products {get; set; }
        public DbSet<ProductBrand> ProductsBrands {get; set; }
        public DbSet<ProductType> ProductsTypes {get; set; }
        public object ProductTypes { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}