using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var points1 = new List<Point>
            {
                new Point(1,5),
                new Point(2,1),
                new Point(3,4),
                new Point(4,1),
                new Point(5,7),
            };
            var points2 = new List<Point>
            {
                new Point(10,25),
                new Point(25,12),
                new Point(37,41),
            };

            var cluster1 = new Cluster(points1);
            var cluster2 = new Cluster(points2);

            var clusterList = new List<Cluster> { cluster1, cluster2 };

            var result = clusterList.SelectMany(c => c.Points);

            //points1.Select(p => p.X).ToList().ForEach(x => Console.WriteLine(x));

            foreach (var p in result)
            {
                Console.WriteLine(p);
            }
        }
    }
}
