using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.LiskovSubstitution
{
    public class CoffeeShop
    {
        private CoffeeMachine _coffeeMachine;

        public CoffeeShop(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public string GetCoffee()
        {
            return _coffeeMachine.GetDrink();
        }
    }
}
