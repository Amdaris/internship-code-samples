using System;

namespace GenericStackDemo.Shapes
{
    public class Rectangle : Shape
    {
        protected int height { get; }
        private int width { get; }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle with Height = {height}, Width = {width}");
        }
    }
}
