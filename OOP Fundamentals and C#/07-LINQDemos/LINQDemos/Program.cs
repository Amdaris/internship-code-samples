using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemos
{
    // Where
    // OrderBy
    // Select
    // SelectMany
    // Anonymous Types
    // LINQ Query Synthax
    // Deffered Execution
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Lenovo Legion", Price = 4000 },
                new Product { Id = 2, Name = "iPhone 12 Pro Max", Price = 6500 },
                new Product { Id = 3, Name = "Samsung S21", Price = 4500 },
                new Product { Id = 4, Name = "Huawei Mate P40 Pro", Price = 4200 },
                new Product { Id = 5, Name = "Macbook Pro 13' 2021", Price = 7500 },
                new Product { Id = 6, Name = "Lenovo Thinkpad T15", Price = 9200 },
                new Product { Id = 7, Name = "Apple Watch Series 6", Price = 2400 },
                new Product { Id = 8, Name = "iPad Pro", Price = 5500 },
            };

            var filteredProducts = products.Where(p => {
                Console.WriteLine($"Trying to filter: {p}");
                return p.Name.Contains("P") && p.Name.Contains("M");
            });

            var sortedProducts = filteredProducts.OrderByDescending(p => p.Price);

            var selectedNames = products.Select(p => p.Name);

            var totalFeatures = products.SelectMany(p => p.Features);

            var filteredProducts2 = from p in products where p.Name.Contains("P") && p.Name.Contains("M") select p.Name;

            var savedFilteredProducts = filteredProducts.ToList();
            savedFilteredProducts.Display();
        }
    }
}
