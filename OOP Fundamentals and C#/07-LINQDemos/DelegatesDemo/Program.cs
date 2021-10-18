using System;

namespace DelegatesDemo
{
    // Use a delegate with a static method
    // Use a lambda instead of static method
    // Use Func instead of delegate
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[]
            {
                new Point(1, 5),
                new Point(1, 2),
                new Point(6, 1),
                new Point(4, 1),
                new Point(8, 5),
            };

            Func<Point, Point, int> func = (a, b) => a.X - b.X;

            Point[] sorted = PointSorter(points, func);

            DisplayPoints(sorted);
        }

        static int XPointComparator(Point a, Point b)
        {
            return a.X - b.X;
        }

        static int YPointComparator(Point a, Point b)
        {
            return a.Y - b.Y;
        }

        static int XThenYComparator(Point a, Point b)
        {
            int x = XPointComparator(a, b);
            if (x == 0)
            {
                return YPointComparator(a, b);
            }
            return x;
        }


        static Point[] PointSorter(Point[] points, Func<Point, Point, int> comparator)
        {
            Point[] result = new Point[points.Length];
            Array.Copy(points, result, points.Length);

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < points.Length - 1; i++)
                {
                    if (comparator(result[i], result[i + 1]) > 0)
                    {
                        Point temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return result;
        }

        static void DisplayPoints(Point[] points)
        {
            foreach (Point p in points)
            {
                Console.WriteLine(p);
            }
        }
    }
}
