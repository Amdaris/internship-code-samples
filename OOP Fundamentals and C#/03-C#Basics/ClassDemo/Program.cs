using System;

namespace ClassDemo
{
    public class CoffeeMachine
    {
        public readonly int MaxCoffeeCount = 100;
        private int _coffeeCount = 0;

        public CoffeeMachine(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void MakeCoffee()
        {
            if (_coffeeCount >= MaxCoffeeCount)
            {
                Console.WriteLine("Coffee machine is full ", Name);
            }

            _coffeeCount += 1;

            Console.WriteLine("Making coffee with {0}", Name);

            Clean();
        }

        protected void Clean()
        {
            Console.WriteLine("Cleaning {0}", Name);
        }
    }

    class AutomaticCoffeeMachine : CoffeeMachine
    {
        public AutomaticCoffeeMachine(string name) : base(name)
        {
        }

        public void MakeCappuccino()
        {
            MakeCoffee();
            MakeMilk();
        }

        public void MakeMilk()
        {
            WarmUp();

            Console.WriteLine("Making milk with {0}", Name);

            Clean();
        }

        private void WarmUp()
        {
            Console.WriteLine("Warming up {0}", Name);
        }

        void DisplayError()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine("My Coffee Machine");
            coffeeMachine.MakeCoffee();

            Console.WriteLine();

            AutomaticCoffeeMachine automaticCoffeeMachine = new AutomaticCoffeeMachine("My Automatic Coffee Machine");
            automaticCoffeeMachine.MakeCappuccino();
        }
    }
}
