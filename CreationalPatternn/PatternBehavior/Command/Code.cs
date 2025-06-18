using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Command
{
    public class ClientCode
    {
        public void Main()
        {
            var repairCommand = new RepairCommands();
            var priceCommand = new PriceCommands();
            Console.WriteLine(repairCommand.Execute("BMW"));
            Console.WriteLine(priceCommand.Execute("200+150+300"));
        }
    }
}