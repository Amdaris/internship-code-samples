using System.Collections.Generic;

namespace ProjectionDemo
{
    public class Cluster
    {
        public Cluster(IEnumerable<Point> points)
        {
            Points = points;
        }

        public IEnumerable<Point> Points { get; }
    }
}
