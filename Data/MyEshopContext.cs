using Microsoft.EntityFrameworkCore;
using MyEshop.Models;

namespace MyEshop.Data
{
    public class MyEshopContext : DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> CategoryToProduct { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Item { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProduct>().HasKey(t => new
            {
                t.ProductId,t.CategoryId
            });
            #region SeedDate Category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "لباس ورزشی",
                Description = "انواع لباس  ورزشی"
            },
              new Category()
              {
                  Id = 2,
                  Name = "لباس راحتی",
                  Description = "انواع لباس خانگی و خواب"
              }
              ,
              new Category()
              {
                  Id = 3,
                  Name = "لباس مجلسی",
                  Description = "انواع لباس مجلسی"
              }

            );

            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
