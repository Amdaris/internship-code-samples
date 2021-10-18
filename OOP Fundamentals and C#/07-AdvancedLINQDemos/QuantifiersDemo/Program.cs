using System;
using System.Linq;

namespace QuantifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Alice", "Charlie", "Daniel" };
            var names2 = new string[] { "Alice", "Charlie", "Daniel" };

            var bobInList = names.Contains("Bob");
            var anyNameWithInitialD = names.Any(n => n.StartsWith("D"));
            var allNamesContainE = names.All(n => n.Contains('e'));
            var seqencesEqual = names.SequenceEqual(names2);

            //Console.WriteLine(bobInList);
            //Console.WriteLine(anyNameWithInitialD);
            //Console.WriteLine(allNamesContainE);
            //Console.WriteLine(seqencesEqual);

            Enumerable.Range(0, 10).ToList().ForEach(e => Console.WriteLine(e));
            Enumerable.Repeat(0, 10).ToList().ForEach(Console.WriteLine);
            Enumerable.Empty<int>();
        }
    }
}
