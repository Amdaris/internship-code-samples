using System;

namespace GenericStackDemo.Shapes
{
    public class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Square with Side = {height}");
        }
    }
}
