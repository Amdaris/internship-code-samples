using System;

namespace ObserverPattern
{
    public class Reader : ISubscriber<Article>
    {
        public Reader(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Notify(Article item)
        {
            Console.WriteLine($@"Hi, I'm {Name} and I'm reading ""{item.Title}"".");
        }
    }
}
