using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Command
{
    public class RepairCommands : ICommand<string, string>
    {
        public string Execute(string carModel)
        {
            return $"Repair completed for {carModel}";
        }
    }

    public class PriceCommands : ICommand<int, string>
    {
        public int Execute(string services)
        {
            var costs = services.Split('+');
            int total = 0;
            foreach(var cost in costs)
            {
                total += int.Parse(cost);
            }
            return total;
        }
    }
}