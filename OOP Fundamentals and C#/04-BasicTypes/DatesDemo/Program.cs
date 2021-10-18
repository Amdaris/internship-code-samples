using System;

namespace DatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;

            DateTimeOffset d3 = DateTimeOffset.Now;
            DateTimeOffset d4 = DateTimeOffset.UtcNow.AddHours(6);

            TimeSpan timespan = d4 - d2;

            Console.WriteLine(d1 + timespan);
        }
    }
}
