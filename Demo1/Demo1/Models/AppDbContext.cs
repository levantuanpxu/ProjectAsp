using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Travel" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Product" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Resaurant food" });

            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                Id = 1, 
                Title = "Bảo Vệ Động Vật", 
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", 
                Full_content= "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 
              // Publish_date="200-10-20", 
                ImageUrl= "https://img.lovepik.com/photo/50075/7988.jpg_wh860.jpg",
                CategoryId=1
            });
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                Id = 2,
                Title = "Bảo Vệ Động Vật",
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Full_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                // Publish_date="200-10-20", 
                ImageUrl = "https://img.lovepik.com/photo/50075/7988.jpg_wh860.jpg",
                CategoryId = 2
            });
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                Id = 3,
                Title = "Bảo Vệ Động Vật",
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Full_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                // Publish_date="200-10-20", 
                ImageUrl = "https://img.lovepik.com/photo/50075/7988.jpg_wh860.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                Id = 4,
                Title = "Bảo Vệ Động Vật",
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Full_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                // Publish_date="200-10-20", 
                ImageUrl = "https://img.lovepik.com/photo/50075/7988.jpg_wh860.jpg",
                CategoryId = 3
            });
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                Id = 5,
                Title = "Bảo Vệ Động Vật",
                Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Full_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                // Publish_date="200-10-20", 
                ImageUrl = "https://img.lovepik.com/photo/50075/7988.jpg_wh860.jpg",
                CategoryId = 3
            });

            modelBuilder.Entity<BlogTag>().HasKey(protag => new { protag.BlogId, protag.TagId });
            //seeder data tag
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 1,
                Name = "Rẻ"
            });

            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 2,
                Name = "Ngon"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 3,
                Name = "Bổ Khỏe"
            });

        }
    }
}
