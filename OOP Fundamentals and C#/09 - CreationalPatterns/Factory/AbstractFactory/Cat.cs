using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    public class Cat : IAnimal
    {
        public string Name { get; set; } = "Cat"; 

        public string MakeSound()
        {
            return "Meow";
        }
    }
}
