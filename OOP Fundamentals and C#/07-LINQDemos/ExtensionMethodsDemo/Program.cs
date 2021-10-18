using System;
using ExtensionMethodsDemo.Extensions;

namespace ExtensionMethodsDemo
{
    // Make GetDiscountedPrice an extension method
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product { Id = 1, Name = "Face Mask x50", Price = 20 };
            Console.WriteLine(product.GetDiscountedPrice(.5f));
        }
    }
}
