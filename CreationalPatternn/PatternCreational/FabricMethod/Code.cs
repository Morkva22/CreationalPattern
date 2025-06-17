using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FactoryMethod
{
    public class ClientCode
    {
        public void Main()
        {
            var cityFactory = new CityCarFactory();
            Console.WriteLine("App: Launched with the CityCarFactory.");
            ClientMethod(cityFactory);
            
            var sportFactory = new SportCarFactory();
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the SportCarFactory.");
            ClientMethod(sportFactory);
        }
        
        public void ClientMethod(CarFactory factory)
        {
            Console.WriteLine(factory.DriveOperation());
            Console.WriteLine(factory.RefuelOperation());
            Console.WriteLine(factory.ParkOperation());
        }
    }
}