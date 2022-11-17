using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.AbstractFactory
{
    public interface IAnimal
    {
        string Name { get; set; }
        string MakeSound();
    }
}
