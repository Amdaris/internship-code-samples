using System;

namespace TemplateMethodPattern
{
    public class Square : Shape
    {
        public Square(int side)
        {
            Side = side;
        }

        public int Side { get; }

        protected override void DrawConcreteShape()
        {
            Console.WriteLine($"Drawing square with side {Side}");
        }
    }
}
