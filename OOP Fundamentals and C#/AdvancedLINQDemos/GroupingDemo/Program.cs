using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product{ Name = "Huawei Matebook", Category = "Laptop" },
                new Product{ Name = "Refrigerator", Category = "Other" },
                new Product{ Name = "Macbook Pro 13", Category = "Laptop" },
                new Product{ Name = "iPhone 15", Category = "Phone" },
                new Product{ Name = "Samsung Note 20 Ultra", Category = "Phone" },
                new Product{ Name = "Microwave", Category = "Other" },
                new Product{ Name = "Lenovo Thinkpad T15", Category = "Laptop" },
                new Product{ Name = "Samsung TV", Category = "Other" },
            };

            var groups = products.GroupBy(p => p.Category);

            foreach(var group in groups)
            {
                Console.WriteLine(group.Key);

                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
        }
    }
}
