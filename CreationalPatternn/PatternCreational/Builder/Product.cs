using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builder
{
    public interface IProduct<T>
    {
        void AddPart(T part);
        void RemovePart(T part);
        void Show();
    }
    
    public class Product<T> : IProduct<T>
    {
        protected List<T> _parts = new List<T>();
        
        public virtual void AddPart(T part)
        {
            _parts.Add(part);
        }
        
        public virtual void RemovePart(T part)
        {
            _parts.Remove(part);
        }
        
        public virtual void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (T part in _parts)
                Console.WriteLine(part);
        }
    }
    
    public class GamingProduct : Product<string>
    {
        public override void Show()
        {
            Console.WriteLine("\nGaming PC Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
    
    public class OfficeProduct : Product<string>
    {
        public override void Show()
        {
            Console.WriteLine("\nOffice PC Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}