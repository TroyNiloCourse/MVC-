using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Order> Order { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit Pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheesse Cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal Pies" });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our Famous Apple Pies",
                LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                CategoryId = 1,
                ImageUrl = "",
                InStock = true, 
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Blue Berry Cheesse cakes",
                Price = 12.95M,
                ShortDescription = "Cheesseyest Cheesse cake",
                LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Cheesse cakes",
                Price = 12.95M,
                ShortDescription = "Cheesseyest Cheesse cake",
                LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Winter cakes",
                Price = 12.95M,
                ShortDescription = "Seasons Pie",
                LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                Name = "4 Season Pie cakes",
                Price = 12.95M,
                ShortDescription = "Seasons Pie",
                LongDescription = "Icing carrot cake Jelly-o-cheesse cakes, that will melts in your mouth",
                CategoryId = 3,
                ImageUrl = "",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "",
                AllergyInformation = ""
            });

        }
    }
}
