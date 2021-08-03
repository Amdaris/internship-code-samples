using GenericStackDemo.Shapes;
using System;

namespace GenericStackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print<Shape>(new Circle(12));
            //var stack = new Stack<Shape>();

            //stack.Push(new Rectangle(10, 20));
            //stack.Push(new Circle(25));
            //stack.Push(new Square(100));

            //stack.Pop().Draw();
            //stack.Pop().Draw();

            Stack<Rectangle> rectangleStack = new Stack<Rectangle>();

            PushShapes(rectangleStack);

            IPopOnlyStack<Rectangle> popStack = rectangleStack;

            PopShapes(popStack);
        }

        public static void PushShapes(IPushOnlyStack<Square> stack)
        {
            stack.Push(new Square(10));
            stack.Push(new Square(20));
            stack.Push(new Square(30));
        }

        public static void PopShapes(IPopOnlyStack<Shape> stack)
        {
            try
            {
                while (true)
                {
                    stack.Pop().Draw();
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Print<T>(T item) where T : Shape
        {
            item.Draw();
        }
    }
}
