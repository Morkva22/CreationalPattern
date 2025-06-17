using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototype
{
    public class ClientCode
    {
        public void Main()
        {
            var originalReport = new Report("Annual Report 2024", "Financial data for 2024", 45);
            Console.WriteLine("App: Created original Report.");
            ClientMethod(originalReport);
            
            var clonedReport = (Report)originalReport.Clone();
            clonedReport.Title = "Quarterly Report Q1 2024";
            clonedReport.PageCount = 12;
            Console.WriteLine("");
            Console.WriteLine("App: Created cloned and modified Report.");
            ClientMethod(clonedReport);
            
            var originalContract = new Contract("Service Agreement", "Software development contract", "TechCorp", "ClientCorp", 24);
            Console.WriteLine("");
            Console.WriteLine("App: Created original Contract.");
            ClientMethod(originalContract);
            
            var clonedContract = (Contract)originalContract.Clone();
            clonedContract.Title = "Maintenance Agreement";
            clonedContract.ClientName = "NewClient Inc";
            clonedContract.Duration = 12;
            Console.WriteLine("");
            Console.WriteLine("App: Created cloned and modified Contract.");
            ClientMethod(clonedContract);
        }
        
        public void ClientMethod(Document document)
        {
            Console.WriteLine($"Title: {document.Title}");
            Console.WriteLine($"Content: {document.Content}");
            document.DisplayInfo();
        }
    }
}