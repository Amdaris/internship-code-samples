using System;

namespace OverloadingDemo
{
    class Calculator
    {

        public int Calculate(params int[] a)
        {
            int sum = 10;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }
        public int Calculate(int a)
        {
            return a;
        }

        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int s = c.Calculate(1, 2);
            Console.WriteLine(s);
        }
    }
}
