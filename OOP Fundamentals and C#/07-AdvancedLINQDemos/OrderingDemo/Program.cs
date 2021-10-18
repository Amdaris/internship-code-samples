using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderingDemo
{
    // OrderByDescending
    // ThenBy
    // ThenByDescending
    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<Point>
            {
                new Point(1, 5),
                new Point(2, 1),
                new Point(1, 4),
                new Point(4, 1),
                new Point(4, 7),
            };

            var ordered = points.OrderBy(p => p.X).ThenBy(p => p.Y);

            foreach(var o in ordered)
            {
                Console.WriteLine(o);
            }

        }
    }
}
