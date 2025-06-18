using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Bridge
{
    public enum CoffeeSize
    {
        Small,
        Large
    }

    public interface ICoffeeSize
    {
        string Name { get; }
        CoffeeSize CoffeeSize { get; }
        string GetCoffeeSize();
    }

    public class SmallCoffee : ICoffeeSize
    {
        public string Name => CoffeeSize.Small.ToString();
        public CoffeeSize CoffeeSize => CoffeeSize.Small;
        public string GetCoffeeSize()
        {
            return Name;
        }
    }

    public class LargeCoffee : ICoffeeSize
    {
        public string Name => CoffeeSize.Large.ToString();
        public CoffeeSize CoffeeSize => CoffeeSize.Large;
        public string GetCoffeeSize()
        {
            return Name;
        }
    }

    public abstract class Coffee
    {
        public string Name { set; get; }
        public ICoffeeSize CoffeeSize { set; get; }
        public abstract string GetCoffee();
    }

    public class CoffeeSmall : Coffee
    {
        public CoffeeSmall(string name)
        {
            this.Name = name;
            this.CoffeeSize = new SmallCoffee();
        }

        public override string GetCoffee()
        {
            return $"{Name} with {CoffeeSize.GetCoffeeSize()} size";
        }
    }

    public class CoffeeLarge : Coffee
    {
        public CoffeeLarge(string name)
        {
            this.Name = name;
            this.CoffeeSize = new LargeCoffee();
        }

        public override string GetCoffee()
        {
            return $"{Name} with {CoffeeSize.GetCoffeeSize()} size";
        }
    }
}