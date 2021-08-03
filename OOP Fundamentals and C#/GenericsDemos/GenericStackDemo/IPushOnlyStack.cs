namespace GenericStackDemo
{
    public interface IPushOnlyStack<in T>
    {
        void Push(T item);
    }
}
