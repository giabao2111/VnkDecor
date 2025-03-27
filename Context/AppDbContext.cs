using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VnkDecor.Models;

namespace VnkDecor.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
              new User
              {
                  Id = 1,
                  Email = "admin@VnK.com",
                  Password = "Gi@bao0903" // 🔴 Cần mã hóa mật khẩu trong thực tế!
              }
          );
            // Cấu hình quan hệ 1-N giữa Product và ProductImage
            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductImages)
                .WithOne(pi => pi.Product)
                .HasForeignKey(pi => pi.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
               .HasMany(c => c.Brands)
               .WithOne(b => b.Category)
               .HasForeignKey(b => b.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Brand>()
                .HasMany(b => b.Products)
                .WithOne(p => p.Brand)
                .HasForeignKey(p => p.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
