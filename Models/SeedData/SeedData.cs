using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LocalNest.Server.Data;
using System;
using System.Linq;

namespace LocalNest.Server.Models.SeedData
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LocalNestDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LocalNestDbContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Handmade Wooden Chair",
                        Description = "A beautifully crafted wooden chair, perfect for any home.",
                        Image_URL = "https://img.freepik.com/premium-vector/decorative-ornamental-square-frame-border-with-geometric-lines-nouveau-style-design_1226483-13552.jpg?semt=ais_hybrid",
                        Price = 49.99,
                        stock = 10,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Product
                    {
                        Name = "Organic Cotton T-Shirt",
                        Description = "Soft and sustainable organic cotton t-shirt, available in various sizes.",
                        Image_URL = "https://img.freepik.com/premium-vector/decorative-ornamental-square-frame-border-with-geometric-lines-nouveau-style-design_1226483-13552.jpg?semt=ais_hybrid",
                        Price = 19.99,
                        stock = 25,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Product
                    {
                        Name = "Artisan Coffee Mug",
                        Description = "A unique, hand-painted coffee mug for your morning brew.",
                        Image_URL = "https://img.freepik.com/premium-vector/decorative-ornamental-square-frame-border-with-geometric-lines-nouveau-style-design_1226483-13552.jpg?semt=ais_hybrid",
                        Price = 12.99,
                        stock = 50,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Product
                    {
                        Name = "Recycled Notebook",
                        Description = "Eco-friendly notebook made from 100% recycled paper.",
                        Image_URL = "https://img.freepik.com/premium-vector/decorative-ornamental-square-frame-border-with-geometric-lines-nouveau-style-design_1226483-13552.jpg?semt=ais_hybrid",
                        Price = 4.99,
                        stock = 100,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
