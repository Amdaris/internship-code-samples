using System;
using System.Linq;

namespace SetDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers1 = new int[] { 1, 2, 3, 3, 3 };
            var numbers2 = new int[] { 12, 62, 63, 12, 2 };

            var result = numbers1.Concat(numbers2);
            //var result = numbers1.Union(numbers2);
            //var result = numbers1.Intersect(numbers2);
            //var result = numbers1.Except(numbers2);

            foreach (var a in result)
            {
                Console.WriteLine(a);
            }
        }
    }
}
