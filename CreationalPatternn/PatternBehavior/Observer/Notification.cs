using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public interface INotificationPlatform<T>
    {
        public void AddShop(Shop<T> shop);
        public void RemoveShop(Shop<T> shop);
        public void NotifyShops(T newData);
        public void NotifyShop(T newData, string name);
        public void AddCustomerToShops(Customer<T> customer);
        public void AddCustomerToShop(Customer<T> customer, string name);
        public void RemoveCustomerFromShop(Customer<T> customer, string name);
        public void RemoveCustomerFromShops(Customer<T> customer);
    }
    public class NotificationPlatform<T> : INotificationPlatform<T>
    {
        public string Name { get; set; }
        private List<Shop<T>> _shops;
        public NotificationPlatform()
        {
            _shops = new List<Shop<T>>();
        }
        public NotificationPlatform(string name) : this()
        {
            Name = name;
        }
        public void AddShop(Shop<T> shop)
        {
            Console.WriteLine($"Shop {shop.Name} is added to {Name}.");
            _shops.Add(shop);
            Console.WriteLine();
        }
        public void RemoveShop(Shop<T> shop)
        {
            Console.WriteLine($"Shop {shop.Name} is removed from {Name}.");
            _shops.Remove(shop);
            Console.WriteLine();
        }
        public void NotifyShops(T newData)
        {
            foreach (var shop in _shops)
            {
                Console.WriteLine($"{shop.Name} start Notify:");
                shop.NotifyCustomers(newData);
                Console.WriteLine();
            }
        }
        public void NotifyShop(T newData, string name)
        {
            foreach (var shop in _shops)
            {
               
                if (shop.Name == name)
                {
                    Console.WriteLine($"{shop.Name} change state:");
                    shop.ChangeState(newData);
                    Console.WriteLine();
                }
            }
        }
        public void AddCustomerToShops(Customer<T> customer)
        {
            foreach (var shop in _shops)
            {
                Console.WriteLine($"{shop.Name} added new customer: "); 
                shop.AddCustomer(customer);
                Console.WriteLine();
            }
        }
        public void AddCustomerToShop(Customer<T> customer, string name)
        {
            foreach (var shop in _shops)
            {
                if (shop.Name == name)
                {
                    Console.WriteLine($"{shop.Name} added new customer {customer.Name}: ");
                    shop.AddCustomer(customer);
                    Console.WriteLine();
                }
            }
        }
        public void RemoveCustomerFromShop(Customer<T> customer, string name)
        {
            foreach (var shop in _shops)
            {
                if (shop.Name == name)
                {
                    Console.WriteLine($"{shop.Name} removed customer: ");
                    shop.RemoveCustomer(customer);
                    Console.WriteLine();
                }
            }
        }
        public void RemoveCustomerFromShops(Customer<T> customer)
        {
            foreach (var shop in _shops)
            {
                Console.WriteLine($"{shop.Name} removed customer: ");
                shop.RemoveCustomer(customer);
                Console.WriteLine();
            }
        }
    }
}