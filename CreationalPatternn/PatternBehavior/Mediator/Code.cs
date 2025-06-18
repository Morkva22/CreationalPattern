using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Mediator
{
    public class ClientCode
    {
        public void Main()
        {
            Mediator mediator = new Mediator();
            mediator.AddComponent("laptop", new ComponentLaptopStore("Laptop Store"));
            mediator.AddComponent("phone", new ComponentPhoneStore("Phone World"));
            mediator.AddComponent("tablet", new ComponentTabletStore("Tablet Center"));
            string sender = "laptop";
            mediator.Notify(sender);
            mediator.RemoveComponent("phone");
            sender = "phone";
            mediator.Notify(sender);
        }
    }
}