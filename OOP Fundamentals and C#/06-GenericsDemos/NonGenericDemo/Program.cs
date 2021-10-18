using System;

namespace NonGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stack = new Stack();

            //stack.Push(1);
            //stack.Push('x');
            //stack.Push(2.5);
            //stack.Push("AC Recas nu e Poli");
            //stack.Push(new object());
            //stack.Push(new int[2] { 10, 20 });

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            var stringStack = new StringStack();

            stringStack.Push("ksjdgndsfkjlgdsf");
            stringStack.Push("fdhdfu54rh");
            stringStack.Push("dhh534h");
            stringStack.Push("dsg43g43g");
            stringStack.Push("kl7ykj76j6");

            string j = stringStack.Pop();

            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Pop());
        }
    }
}
