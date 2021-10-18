using System;

namespace PointDemo
{
    // p2 = p1
    // class
    // == operator
    public struct Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        //public static bool operator ==(Point p1, Point p2)
        //{
        //    return p1.X == p2.X && p1.Y == p2.Y;
        //}

        //public static bool operator !=(Point p1, Point p2) 
        //{
        //    return !(p1 == p2);
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point();
            //Point p2 = new Point();

            //Console.WriteLine(p1 == p2);

            int a = 12;
            object o = a;
            bool? b = o as bool?;

            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
