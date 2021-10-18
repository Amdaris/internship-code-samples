namespace VisitorPattern
{
    public abstract class Shape : IVisitable
    {
        public abstract void Accept(IVisitor visitor);
    }
}
