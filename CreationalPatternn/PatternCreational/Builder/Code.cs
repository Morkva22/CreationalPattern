using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builder
{
    public class ClientCode
    {
        public void Main()
        {
            var gamingPCBuilder = new GamingPCBuilder();
            var director = new Director(gamingPCBuilder);
            Console.WriteLine("App: Launched with the GamingPCBuilder.");
            director.BuildGamingPC();
            Console.WriteLine("");
            Console.WriteLine("App: Disassembling the GamingPC.");
            director.DisassembleGamingPC();
            
            var officePCBuilder = new OfficePCBuilder();
            director = new Director(officePCBuilder);
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the OfficePCBuilder.");
            director.BuildOfficePC();
            Console.WriteLine("");
            Console.WriteLine("App: Disassembling the OfficePC.");
            director.DisassembleOfficePC();
            
            var minimalPCBuilder = new GamingPCBuilder();
            director = new Director(minimalPCBuilder);
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the MinimalPCBuilder.");
            director.BuildMinimalPC();
            Console.WriteLine("");
            Console.WriteLine("App: Disassembling the MinimalPC.");
            director.DisassembleMinimalPC();
        }
    }
}