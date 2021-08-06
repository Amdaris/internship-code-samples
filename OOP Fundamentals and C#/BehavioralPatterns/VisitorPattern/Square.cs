namespace VisitorPattern
{
    public class Square : Shape
    {
        public Square(int length)
        {
            Length = length;
        }

        public int Length { get; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
