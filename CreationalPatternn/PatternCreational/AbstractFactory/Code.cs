using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactory
{
    public class ClientCode
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the IkeaFactory.");
            ClientMethod(new IkeaFactory());
            Console.WriteLine("");
            
            Console.WriteLine("App: Launched with the AshleyFactory.");
            ClientMethod(new AshleyFactory());
            Console.WriteLine("");
            
            Console.WriteLine("App: Launched with the WestElmFactory.");
            ClientMethod(new WestElmFactory());
        }
        
        public void ClientMethod(IFurnitureFactory furnitureFactory)
        {
            var sofa = furnitureFactory.CreateSofa();
            var table = furnitureFactory.CreateTable();
            
            Console.WriteLine(sofa.SitOn());
            Console.WriteLine(sofa.Assemble());
            Console.WriteLine(sofa.Clean());
            Console.WriteLine();
            
            Console.WriteLine(table.Place());
            Console.WriteLine(table.Assemble());
            Console.WriteLine(table.Polish());
        }
    }
}