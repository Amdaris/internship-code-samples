using System;

namespace OOPFundamentals.OpenClose
{
    public class CircleRefactored : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}