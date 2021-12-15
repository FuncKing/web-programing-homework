using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) {}

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductSeries> productSeries { get; set; }
        public DbSet<Seller> sellers { get; set; }
        public DbSet<Sale> sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSeries>()
                .HasOne(p => p.product)
                .WithMany(b => b.productSeries)
                .HasForeignKey("ProductId");

            modelBuilder.Entity<ProductSeries>()
                .HasOne(p => p.seller)
                .WithMany(b => b.productSeries)
                .HasForeignKey("SellerId");

            modelBuilder.Entity<Sale>()
                .HasOne(p => p.productSeries)
                .WithMany(b => b.sales)
                .HasForeignKey("SaleId");
        }
    }
}
