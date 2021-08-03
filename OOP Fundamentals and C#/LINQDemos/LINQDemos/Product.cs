using System.Collections.Generic;

namespace LINQDemos
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public IEnumerable<string> Features { get; set; } = new List<string> { "Good", "Cheap" };

        public override string ToString() => $"({Id}, {Name}, {Price})";
    }
}
