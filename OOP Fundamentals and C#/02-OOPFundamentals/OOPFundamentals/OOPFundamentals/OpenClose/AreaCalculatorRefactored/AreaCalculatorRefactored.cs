using System;

namespace OOPFundamentals.OpenClose
{
    public class AreaCalculatorRefactored
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
