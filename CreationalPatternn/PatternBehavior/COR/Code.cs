using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CoR
{
    public class ClientCode
    {
        public void Main()
        {
            var level1 = new Level1SupportHandler();
            var level2 = new Level2SupportHandler();
            var level3 = new Level3SupportHandler();
            var manager = new ManagerHandler();

            level1.SetNext(level2).SetNext(level3).SetNext(manager);

            Console.WriteLine("Client: Processing support requests...\n");

            var request1 = new SupportRequest("Password reset needed", Priority.Low, "John Smith");
            var result = level1.Handle(request1);
            Console.WriteLine(result);

            var request2 = new SupportRequest("Software installation issue", Priority.Medium, "Alice Johnson");
            result = level1.Handle(request2);
            Console.WriteLine(result);

            var request3 = new SupportRequest("Server performance problems", Priority.High, "Bob Wilson");
            result = level1.Handle(request3);
            Console.WriteLine(result);

            var request4 = new SupportRequest("Critical system failure", Priority.Critical, "Sarah Davis");
            result = level1.Handle(request4);
            Console.WriteLine(result);
        }
    }
}