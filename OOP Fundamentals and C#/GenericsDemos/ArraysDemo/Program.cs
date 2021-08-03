using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ArraysDemo
{
    class StringComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.Length == y.Length;
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj.Length.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10];
            //array[0] = 15;

            // Console.WriteLine(array[1]);

            //ICollection<string> strings = new List<string> { "Abc" };

            Dictionary<string, int> d = new Dictionary<string, int> {
                {"a", 1 },
                {"b", 2 },
                {"c", 3 },
            };

            //Console.WriteLine(d["a"]);

            var set = new HashSet<string>(new StringComparer());

            set.Add("a");
            set.Add("b");
            set.Add("b");

            foreach (var e in set)
            {
                Console.WriteLine(e);
            }

            //int[][] matrix = new int[3][];
            //matrix[0] = new int[] { 0, 1, 2, 3 };
            //matrix[1] = new int[] { 0, 1, 2, 3, 4 };
            //matrix[2] = new int[] { 0, 1, 2, 3, 4, 5 };

            //Console.WriteLine(matrix.Length);

            //int[,] matrix2 = new int[3, 4];
            //matrix2[1, 2] = 15;

            //Console.WriteLine(matrix2.Length);

            // Omit size on initialization
            //int[,] matrix3 = new int[,]
            //{
            //    { 1, 2, 3, 5 },
            //    { 4, 5, 6, 7 },
            //};

            //Console.WriteLine(matrix3.Length);

            //int[][,,][,] m = new int[3][,,][,];
            //m[0] = new int[3, 5, 3][,];
            //m[0][0, 0, 0] = new int[2, 2];

            //Console.WriteLine(m[1][0, 0, 0][0, 0]);

        }
    }
}
