using Pattern.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Decorator
{
    public class ClientCode
    {
        public void CoffeeOrder(List<ICoffee> coffees)
        {
            foreach (var coffee in coffees)
            {
                Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost():F2}");
            }
            Console.WriteLine();
        }

        public void Main()
        {
            ICoffee espresso = new Espresso("Classic");
            ICoffee americano = new Americano("Premium");
            ICoffee cappuccino = new Cappuccino("Italian");

            var morningOrders = new List<ICoffee>();
            morningOrders.Add(new SugarDecorator(espresso));

            var afternoonOrders = new List<ICoffee>();
            afternoonOrders.Add(new MilkDecorator(americano));
            afternoonOrders.Add(new VanillaDecorator(americano));
            afternoonOrders.Add(new WhippedCreamDecorator(americano));

            var eveningOrders = new List<ICoffee>();
            eveningOrders.Add(new CaramelDecorator(cappuccino));

            Console.WriteLine("=== Morning Orders ===");
            CoffeeOrder(morningOrders);

            Console.WriteLine("=== Afternoon Orders ===");
            CoffeeOrder(afternoonOrders);

            Console.WriteLine("=== Evening Orders ===");
            CoffeeOrder(eveningOrders);
        }
    }
}