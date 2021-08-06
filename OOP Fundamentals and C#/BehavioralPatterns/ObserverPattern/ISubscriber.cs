namespace ObserverPattern
{
    public interface ISubscriber<T>
    {
        void Notify(T item);
    }
}
