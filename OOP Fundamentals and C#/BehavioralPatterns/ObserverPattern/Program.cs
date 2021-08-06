using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editorial = new Editorial();

            var andrei = new Reader("Andrei");
            var marcel = new Reader("Marcel");
            var radu = new Reader("Radu");

            editorial.AddSubscriber(andrei);
            editorial.AddSubscriber(marcel);
            editorial.AddSubscriber(radu);

            editorial.Publish(new Article("Real Madrid 2 - 0 Barcelona", "Hala Madrid", DateTime.Now));
        }
    }
}
