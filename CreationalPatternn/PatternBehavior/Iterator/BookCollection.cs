using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Iterator
{
    public class BookCollection : IAggregate
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public int Count
        {
            get { return books.Count; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }

        public IIterator CreateIterator()
        {
            return new BookIterator(this);
        }
    }
}