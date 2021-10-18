using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
        public void Visit(Square square)
        {
            Console.WriteLine($"Drawing square with length {square.Length} on blackboard");
        }

        public void Visit(Circle circle)
        {
            Console.WriteLine($"Drawing circle with radius {circle.Radius} on blackboard");
        }
    }
}
