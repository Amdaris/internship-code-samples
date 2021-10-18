using System;
using System.Linq;

namespace FilteringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2 };
            var filtered = numbers.Where(n => n % 2 == 0);
            //var filtered = numbers.Take(3);
            //var filtered = numbers.Skip(5);
            //var filtered = numbers.TakeWhile(n => n < 5);
            //var filtered = numbers.SkipWhile(n => n < 5);
            //var filtered = numbers.Distinct();

            foreach (var n in filtered)
            {
                Console.WriteLine(n);
            }
        }
    }
}
