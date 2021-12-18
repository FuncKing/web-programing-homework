using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ShopContext : IdentityDbContext<User>
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) {}

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
                .HasForeignKey("ProductSeriesId");

            modelBuilder.Entity<Sale>()
                .HasOne(p => p.user)
                .WithMany(b => b.sales)
                .HasForeignKey("UserId");

            base.OnModelCreating(modelBuilder);

            this.SeedUsers(modelBuilder);
            this.SeedRoles(modelBuilder);
            this.SeedUserRoles(modelBuilder);
        }

        private void SeedUsers(ModelBuilder builder)
        {
            User mertcany = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "g191210018@sakarya.edur.tr",
                NormalizedUserName = "G191210018@SAKARYA.EDU.TR",
                Email = "g191210018@sakarya.edur.tr",
                NormalizedEmail = "G191210018@SAKARYA.EDU.TR",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            User alihan = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e6",
                UserName = "g191210057@sakarya.edur.tr",
                NormalizedUserName = "G191210057@SAKARYA.EDU.TR",
                Email = "g191210057@sakarya.edur.tr",
                NormalizedEmail = "G191210057@SAKARYA.EDU.TR",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            var mchashedPassword=passwordHasher.HashPassword(mertcany, "123");
            var alhnhashedPassword = passwordHasher.HashPassword(alihan, "123");

            mertcany.PasswordHash = mchashedPassword;
            alihan.PasswordHash = alhnhashedPassword;

            builder.Entity<User>().HasData(mertcany);
            builder.Entity<User>().HasData(alihan);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e6" }
                );
        }
    }
}

