using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    public class Lion : IAnimal
    {
        public string Name { get; set; } = "Lion";
        public string MakeSound()
        {
            return "Roarr";
        }
    }
}
