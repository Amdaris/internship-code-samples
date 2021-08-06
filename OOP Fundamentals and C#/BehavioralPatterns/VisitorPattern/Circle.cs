namespace VisitorPattern
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
