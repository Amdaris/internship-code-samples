namespace StrategyPattern
{
    public class Square : Shape
    {
        public Square(int length)
        {
            Length = length;
        }

        public int Length { get; }

        public override string GetDrawMessage() => $"Drawing square with length {Length}";
    }
}
