using System;

namespace NonGenericDemo
{
    public class StringStack
    {
        private readonly int maxSize;
        private int index;
        private string[] items;

        public StringStack(int maxSize = 10)
        {
            this.maxSize = maxSize;
            this.items = new string[maxSize];
            this.index = 0;
        }

        public void Push(string item)
        {
            if (index >= maxSize)
            {
                throw new InvalidOperationException("Stack is full");
            }

            items[index++] = item;
        }

        public string Pop()
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
