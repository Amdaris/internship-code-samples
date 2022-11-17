using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    public class Dog : IAnimal
    {
        public string Name { get; set; } = "Dog";

        public string MakeSound()
        {
            return "Woff";
        }
    }
}
