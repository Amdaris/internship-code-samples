using System;

namespace GenericStackDemo.Shapes
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle with Radius = {radius}");
        }
    }
}
