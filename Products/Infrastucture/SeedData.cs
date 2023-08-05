using Products.Infrastucture;
using Products.Models;

﻿using Microsoft.EntityFrameworkCore;


namespace Products.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category smartphones = new Category { Name = "Smartphones", Slug = "smartphones" };
                Category laptops = new Category { Name = "Laptops", Slug = "laptops" };
                Category fragrances = new Category { Name = "Fragrances", Slug = "fragrances" };
                Category skincare = new Category { Name = "Skincare", Slug = "skincare" };
                Category groceries = new Category { Name = "Groceries", Slug = "groceries" };
                Category furniture = new Category { Name = "Furniture", Slug = "furniture" };

                context.Products.AddRange(
                        new Product
                        {
                            Title = "Iphone",
                            Slug = "iphone",
                            Description = "Mobile Phone",
                            DiscountPercentage= 12.96,
                            Rating= 76,
                            Stock=58,
                            Brand = "Apple",
                            Price = 549,
                            Category = smartphones,
                            Image = "iphone.jpg"
                        },
                        new Product
                        {
                            Title = "MacBook",
                            Slug = "macbook",
                            Description = "Laptop",
							DiscountPercentage = 5,
							Rating = 95,
							Stock = 77,
							Brand = "Apple",
							Price = 800,
                            Category = laptops,
                            Image = "macbook.jpg"
                        },
                        new Product
                        {
                            Title = "Dior",
                            Slug = "dior",
                            Description = "Fragrant Fragrance",
							DiscountPercentage = 7.6,
                            Rating = 67,
							Stock = 12,
							Brand = "Dior",
							Price = 100,
                            Category = fragrances,
                            Image = "dior.jpg"
                        },
                        new Product
                        {
                            Title = "Garnier",
                            Slug = "garnier",
                            Description = "Good for your skin",
							DiscountPercentage = 3,
                            Rating = 87,
							Stock = 94,
							Brand = "Garnier",
							Price = 20,
                            Category = skincare,
                            Image = "garnier.jpg"
                        },
                        new Product
                        {
                            Title = "Sprite",
                            Slug = "sprite",
                            Description = "Drink cold",
							DiscountPercentage = 7.1,
                            Rating = 65,
							Stock = 5,
							Brand = "Sprite",
							Price = 5,
                            Category = groceries,
                            Image = "sprite.jpg"
                        },
                        new Product
                        {
                            Title = "Ikea",
                            Slug = "ikea",
							DiscountPercentage = 25,
                            Rating = 85,
							Stock = 22,
							Brand = "Ikea",
							Description = "Home Stuffs",
                            Price = 100,
                            Category = furniture,
                            Image = "ikea.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}