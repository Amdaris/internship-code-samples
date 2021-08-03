namespace DelegatesDemo
{
    public class Point
    {
        public delegate int PointComparatorDelegate(Point a, Point b);
        
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }
        public int Y { get; }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
