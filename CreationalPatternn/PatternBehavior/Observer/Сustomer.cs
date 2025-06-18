using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public interface ICustomer<T>
    {
        public string Name { set; get; }
        bool IsSubscribed();
        string Update(T data);
        void ChangeSubscription();
    }
    public class Customer<T> : ICustomer<T>
    {
        public string Name { set; get; }
        private bool _isSubscribed = false;
        public bool IsSubscribed()
        {
            return _isSubscribed;
        }
        public string Update(T data)
        {
            return $"Customer {Name} gets: {data}.";
        }
        public void ChangeSubscription()
        {
            _isSubscribed = !_isSubscribed;
        }
        public Customer(string name)
        {
            Name = name;
        }
    }
}