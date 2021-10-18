namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(Square square);
        void Visit(Circle circle);
    }
}
