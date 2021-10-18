using System;

namespace RefsDemo
{
    public struct Point
    {
        public int X;
        public int Y;

        public static Point Origin = new Point { X = 0, Y = 0 };
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point { X = 0, Y = 0 };

            Change(ref p);

            Console.WriteLine(p.X + ", " + p.Y);

            Console.ReadKey();
        }

        static void Change(ref Point a)
        {
            a = new Point { X = 1, Y = 0 };
        }
    }
}
