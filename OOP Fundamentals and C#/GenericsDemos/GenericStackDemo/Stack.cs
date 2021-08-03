using GenericStackDemo.Shapes;
using System;

namespace GenericStackDemo
{
    public class Stack<T> : IPushOnlyStack<T>, IPopOnlyStack<T>
    {
        private readonly int maxSize;
        private int index;
        private T[] items;

        public Stack(int maxSize = 10)
        {
            this.maxSize = maxSize;
            this.items = new T[maxSize];
            this.index = 0;
        }

        public void Push(T item)
        {
            if (index >= maxSize)
            {
                throw new InvalidOperationException("Stack is full");
            }

            items[index++] = item;
        }

        public T Pop()
        {
            index--;

            if (index >= 0)
            {
                return items[index];
            }

            index = 0;
            throw new InvalidOperationException("Stack is empty");
        }

    }
}
