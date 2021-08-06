using System;

namespace TemplateMethodPattern
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; }

        protected override void DrawConcreteShape()
        {
            Console.WriteLine($"Drawing circle with radius {Radius}");
        }
    }
}
