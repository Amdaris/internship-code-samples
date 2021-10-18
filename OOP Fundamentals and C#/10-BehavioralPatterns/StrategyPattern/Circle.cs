namespace StrategyPattern
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; }

        public override string GetDrawMessage() => $"Drawing circle with radius {Radius}";
    }
}
