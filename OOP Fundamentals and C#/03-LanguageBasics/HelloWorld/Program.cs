using HelloWorld.Hello;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            int x = 2;
            Console.WriteLine("Hello World!");
            Console.WriteLine(x);

            string input = Console.ReadLine();
            Console.WriteLine("You have typed: " + input);

            Console.ReadKey();
        }
    }
}
