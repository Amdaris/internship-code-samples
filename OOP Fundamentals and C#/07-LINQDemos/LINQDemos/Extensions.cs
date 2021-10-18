using System;
using System.Collections.Generic;

namespace LINQDemos
{
    public static class Extensions
    {
        public static void Display<T>(this IEnumerable<T> source)
        {
            foreach (var element in source)
            {
                Console.WriteLine(element);
            }
        }
    }
}
