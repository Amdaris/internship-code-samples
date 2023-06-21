using System;

namespace InheritanceDemo
{
    public interface IGeometry
    {
        void Draw();

        void SanityCheck()
        {
            Console.WriteLine("Sanity check");
        }
    }

    public abstract class Geometry : IGeometry
    {
        public abstract Color Color { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a geometrical form with the following color: " + Color.Name);
        }
    }

    public abstract class ComplexGeometry : IGeometry
    {
        public abstract Color Color { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a geometrical complex object form with the following color: " + Color.Name);
        }
    }

    public class Circle : ComplexGeometry
    {
        public int Radius { get; set; }

        public override Color Color { get; set; } = new Color() { Name = "Red" };
    }

    public class Rectangle : Geometry
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override Color Color { get; set; } = new Color() { Name = "Blue" };

        public sealed override void Draw()
        {
            Console.WriteLine("Draw from rectangle");
        }
    }

    public sealed class Square : Rectangle
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            IGeometry[] geometries = new IGeometry[]
            {
                new Rectangle()
                {
                    Height = 20,
                    Width = 10
                },
                new Square()
                {
                    Width = 10
                },
                new Circle()
                {
                    Radius = 100
                },
                new Circle()
                {
                    Radius = 50
                }
            };

            DrawOnCanvas(geometries);
        }

        static void DrawOnCanvas(IGeometry[] geometries)
        {
            foreach (IGeometry geom in geometries)
            {
                geom.SanityCheck();
                geom.Draw();
            }
        }
    }
}
