namespace VisitorPattern
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
