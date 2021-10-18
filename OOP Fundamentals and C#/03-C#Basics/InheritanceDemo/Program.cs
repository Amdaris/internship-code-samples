using System;

namespace InheritanceDemo
{
    // Turn into interface
    interface IShape
    {
        void Draw();
    }

    class Circle : IShape
    {
        public int Radius { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing circle with radius " + Radius);
        }
    }

    class SuperCircle : Circle
    {
        public override void Draw()
        {
            Console.WriteLine("Super circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IShape s = new SuperCircle { Radius = 10 };
            s.Draw();
        }
    }
}
