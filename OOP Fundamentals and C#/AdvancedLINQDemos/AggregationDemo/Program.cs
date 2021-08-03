using System;
using System.Linq;

namespace AggregationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 4, 6, 7, 26, 67, 43, 634, 6, 347 };

            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Count(c => c > 10));
            //Console.WriteLine(numbers.Sum());
            //Console.WriteLine(numbers.Sum(n => -n));
            //Console.WriteLine(numbers.Average());

            var aggregateProduct = numbers.Aggregate(1, (acc, n) => acc * n);
            Console.WriteLine(aggregateProduct);
        }
    }
}
