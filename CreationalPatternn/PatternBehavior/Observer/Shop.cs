using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public interface IShop<T>
    {
        public void AddCustomer(Customer<T> customer);
        public void RemoveCustomer(Customer<T> customer);
        public void NotifyCustomers(T newData);
        public void ChangeState(T state);
    }
    public class Shop<T> : IShop<T>
    {
        public string Name { set; get; }
        private List<Customer<T>> _customers;
        private T _state;
        public Shop()
        {
            _customers = new List<Customer<T>>();
        }
        public Shop(string name) : this()
        {
            this.Name = name;
        }
        public void AddCustomer(Customer<T> customer)
        {
            Console.WriteLine($"Customer {customer.Name} is added to {Name}.");
            _customers.Add(customer);
            Console.WriteLine();
        }
        public void RemoveCustomer(Customer<T> customer)
        {
            Console.WriteLine($"Customer {customer.Name} is removed from {Name}.");
            _customers.Remove(customer);
            Console.WriteLine();
        }
        public void NotifyCustomers(T newData)
        {
            Console.WriteLine($"Shop {Name} notifies its customers:");
            foreach (var customer in _customers)
            {
                Console.WriteLine(customer.Update(newData));
            }
            Console.WriteLine();
        }
        public void ChangeState(T state)
        {
            Console.WriteLine($"Shop {Name} changes its state to {state}.");
            _state = state;
            NotifyCustomers(_state);
            Console.WriteLine();
        }
    }
}