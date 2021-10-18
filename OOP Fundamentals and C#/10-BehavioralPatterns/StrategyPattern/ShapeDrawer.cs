using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ShapeDrawer
    {
        public ShapeDrawer(Shape shape)
        {
            Shape = shape;
        }

        public Shape Shape { get; }

        public void Draw()
        {
            Console.WriteLine("--- Pen Down ---");

            Console.WriteLine(Shape.GetDrawMessage());

            Console.WriteLine("--- Pen Up ---");
        }
    }
}
