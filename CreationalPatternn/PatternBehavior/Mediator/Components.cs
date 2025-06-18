using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Mediator
{
    public interface IComponent
    {
        string Name { get; }
        void ReactOn(object args);
    }

    public class BaseComponent : IComponent
    {
        public string Name { get; }
        public BaseComponent(string name)
        {
            this.Name = name;
        }
        public virtual void ReactOn(object args)
        {
            Console.WriteLine($"Component {this.Name} reacts on {args}.");
        }
    }

    public class ComponentLaptopStore : BaseComponent
    {
        public ComponentLaptopStore(string name) : base(name)
        {}
        public void SellLaptop()
        {
            Console.WriteLine($"Component {this.Name} sells laptop.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            SellLaptop();
        }
    }

    public class ComponentPhoneStore : BaseComponent
    {
        public ComponentPhoneStore(string name) : base(name)
        { }
        public void SellPhone()
        {
            Console.WriteLine($"Component {this.Name} sells phone.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            SellPhone();
        }
    }

    public class ComponentTabletStore : BaseComponent
    {
        public ComponentTabletStore(string name) : base(name)
        { }
        public void SellTablet()
        {
            Console.WriteLine($"Component {this.Name} sells tablet with stylus and protective case.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            SellTablet();
        }
    }
}