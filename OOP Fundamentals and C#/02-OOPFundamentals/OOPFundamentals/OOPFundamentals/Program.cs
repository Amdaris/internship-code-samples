using OOPFundamentals.LiskovSubstitution;
using System;
using System.Diagnostics;

namespace OOPFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liskov

            var coffee1 = new CoffeeShop(new SpecialCoffeeMachine())
                .GetCoffee(); // not really coffee

            var coffee2 = new CoffeeShop(new SpecialCoffeeMachineRefactored())
                .GetCoffee(); // good coffee :)
        }
    }
}
