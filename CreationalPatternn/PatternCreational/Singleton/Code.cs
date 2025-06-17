using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Singleton
{
    public class ClientCode
    {
        public void Main()
        {
            Console.WriteLine("App: Testing Database Singleton");
            
            var database1 = DatabaseManager.GetInstance();
            database1.Connect();
            database1.ExecuteQuery("SELECT * FROM users");
            
            var database2 = DatabaseManager.GetInstance();
            database2.Connect();
            database2.ExecuteQuery("INSERT INTO products VALUES (1, 'Laptop')");
            
            if (database1 == database2)
            {
                Console.WriteLine("Singleton works, both variables contain the same database instance.");
                Console.WriteLine($"Connection count: {database1.GetConnectionCount()}");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
            
            database1.Disconnect();
        }
    }
}