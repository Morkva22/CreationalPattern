using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Singleton
{
    public class DatabaseManager
    {
        private static DatabaseManager? _instance;
        private static object _lock = new object();
        private bool _isConnected;
        private int _connectionCount;
        private string _connectionString;
        
        private DatabaseManager() 
        {
            _isConnected = false;
            _connectionCount = 0;
            _connectionString = "Server=localhost;Database=MyApp;Trusted_Connection=true;";
            Console.WriteLine("DatabaseManager instance created");
        }
        
        public static DatabaseManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseManager();
                    }
                }
            }
            return _instance;
        }
        
        public void Connect()
        {
            if (!_isConnected)
            {
                Console.WriteLine($"Connecting to database: {_connectionString}");
                _isConnected = true;
                _connectionCount++;
                Console.WriteLine("Database connected successfully");
            }
            else
            {
                Console.WriteLine("Database is already connected");
            }
        }
        
        public void Disconnect()
        {
            if (_isConnected)
            {
                Console.WriteLine("Disconnecting from database...");
                _isConnected = false;
                Console.WriteLine("Database disconnected");
            }
            else
            {
                Console.WriteLine("Database is already disconnected");
            }
        }
        
        public void ExecuteQuery(string query)
        {
            if (_isConnected)
            {
                Console.WriteLine($"Executing query: {query}");
                Console.WriteLine("Query executed successfully");
            }
            else
            {
                Console.WriteLine("Error: Database is not connected. Cannot execute query.");
            }
        }
        
        public int GetConnectionCount()
        {
            return _connectionCount;
        }
        
        public bool IsConnected()
        {
            return _isConnected;
        }
        
        public void SetConnectionString(string connectionString)
        {
            if (!_isConnected)
            {
                _connectionString = connectionString;
                Console.WriteLine("Connection string updated");
            }
            else
            {
                Console.WriteLine("Cannot change connection string while connected");
            }
        }
    }
}