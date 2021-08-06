using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class AbstractPublisher<T>
    {
        private List<ISubscriber<T>> subscribers;
        public AbstractPublisher()
        {
            this.subscribers = new List<ISubscriber<T>>();
        }
        public void AddSubscriber(ISubscriber<T> subscriber)
        {
            this.subscribers.Add(subscriber);
        }
        public void Publish(T item)
        {
            this.subscribers.ForEach(s => s.Notify(item));
        }
    }
}
