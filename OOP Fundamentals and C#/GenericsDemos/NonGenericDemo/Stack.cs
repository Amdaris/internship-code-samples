using System;

namespace NonGenericDemo
{
    public class Stack
    {
        private readonly int maxSize;
        private int index;
        private object[] items;

        public Stack(int maxSize = 10)
        {
            this.maxSize = maxSize;
            this.items = new object[maxSize];
            this.index = 0;
        }

        public void Push(object item)
        {
            if (index >= maxSize)
            {
                throw new InvalidOperationException("Stack is full");
            }

            items[index++] = item;
        }

        public object Pop()
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
