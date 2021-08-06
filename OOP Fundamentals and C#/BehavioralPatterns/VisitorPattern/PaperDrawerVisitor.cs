using System;

namespace VisitorPattern
{
    public class PaperDrawerVisitor : IVisitor
    {
        private int capacity = 30;

        public PaperDrawerVisitor(int capacity)
        {
            this.capacity = capacity;
        }

        public void Visit(Square square)
        {
            if (capacity - square.Length < 0)
            {
                ShowError();
                throw new InvalidOperationException($"Current capacity {capacity} but tried to draw square of length {square.Length}");
            }
            Console.WriteLine($"Drawing square with length {square.Length} on paper");
            capacity -= square.Length;
        }

        public void Visit(Circle circle)
        {
            int diameter = 2 * circle.Radius;
            if (capacity - diameter < 0)
            {
                ShowError();
                throw new InvalidOperationException($"Current capacity {capacity} but tried to draw circle of diameter {diameter}");
            }
            Console.WriteLine($"Drawing circle with radius {circle.Radius} on paper");
            capacity -= diameter;
        }

        private static void ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Max capacity reached");
            Console.ResetColor();
        }
    }
}
