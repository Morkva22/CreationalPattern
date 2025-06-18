using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge
{
    public class ClientCode
    {
        public void Main()
        {
            Coffee coffee = new CoffeeSmall("Espresso");
            Console.WriteLine(coffee.GetCoffee());
            Coffee coffee2 = new CoffeeLarge("Americano");
            Console.WriteLine(coffee2.GetCoffee());
        }
    }
}