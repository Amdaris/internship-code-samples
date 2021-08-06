using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(12);
            ShapeDrawer drawer = new ShapeDrawer(shape);
            drawer.Draw();
        }
    }
}
