using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Decorator.Addons
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.30;
        }
    }
}