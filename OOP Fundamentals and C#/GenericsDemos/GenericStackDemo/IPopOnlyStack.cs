namespace GenericStackDemo
{
    public interface IPopOnlyStack<out T>
    {
        T Pop();
    }
}
