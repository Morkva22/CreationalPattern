using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Iterator
{
    public interface IIterator
    {
        object Current();
        bool IsDone();
        void Next();
        void Reset();
    }

    public interface IAggregate
    {
        IIterator CreateIterator();
    }

    public class BookIterator : IIterator
    {
        private BookCollection collection;
        private int currentIndex = 0;

        public BookIterator(BookCollection collection)
        {
            this.collection = collection;
        }

        public object Current()
        {
            return collection[currentIndex];
        }

        public bool IsDone()
        {
            return currentIndex >= collection.Count;
        }

        public void Next()
        {
            currentIndex++;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}