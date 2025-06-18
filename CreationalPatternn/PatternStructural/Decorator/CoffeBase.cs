using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Decorator
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    public class Espresso : ICoffee
    {
        private readonly string _type;
        public Espresso(string type) => _type = type;
        public string GetDescription() => $"{_type} Espresso";
        public double GetCost() => 2.00;
    }

    public class Americano : ICoffee
    {
        private readonly string _type;
        public Americano(string type) => _type = type;
        public string GetDescription() => $"{_type} Americano";
        public double GetCost() => 2.50;
    }

    public class Cappuccino : ICoffee
    {
        private readonly string _type;
        public Cappuccino(string type) => _type = type;
        public string GetDescription() => $"{_type} Cappuccino";
        public double GetCost() => 3.00;
    }
}

namespace Pattern.Decorator.Decorators
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee Coffee;
        protected CoffeeDecorator(ICoffee coffee) => Coffee = coffee;
        public virtual string GetDescription() => Coffee.GetDescription();
        public virtual double GetCost() => Coffee.GetCost();
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => $"{Coffee.GetDescription()}, Sugar";
        public override double GetCost() => Coffee.GetCost() + 0.20;
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => $"{Coffee.GetDescription()}, Milk";
        public override double GetCost() => Coffee.GetCost() + 0.30;
    }

    public class VanillaDecorator : CoffeeDecorator
    {
        public VanillaDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => $"{Coffee.GetDescription()}, Vanilla";
        public override double GetCost() => Coffee.GetCost() + 0.50;
    }

    public class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => $"{Coffee.GetDescription()}, Whipped Cream";
        public override double GetCost() => Coffee.GetCost() + 0.70;
    }

    public class CaramelDecorator : CoffeeDecorator
    {
        public CaramelDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => $"{Coffee.GetDescription()}, Caramel";
        public override double GetCost() => Coffee.GetCost() + 0.80;
    }
}