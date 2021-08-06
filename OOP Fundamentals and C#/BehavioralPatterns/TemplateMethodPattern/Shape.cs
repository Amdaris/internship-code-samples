using System;

namespace TemplateMethodPattern
{
    public abstract class Shape
    {
        public void Draw()
        {
            Console.WriteLine("--- Pen Down ---");

            DrawConcreteShape();

            Console.WriteLine("--- Pen Up ---");
        }

        protected abstract void DrawConcreteShape();
    }
}
