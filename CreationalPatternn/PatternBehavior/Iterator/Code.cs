using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Iterator
{
    public class ClientCode
    {
        public void Main()
        {
            BookCollection collection = new BookCollection();
            collection.AddBook(new Book("Clean Code", "Robert Martin"));
            collection.AddBook(new Book("Design Patterns", "Gang of Four"));
            collection.AddBook(new Book("Refactoring", "Martin Fowler"));
            
            IIterator iterator = collection.CreateIterator();
            
            while (!iterator.IsDone())
            {
                Book book = (Book)iterator.Current();
                Console.WriteLine($"Book: {book.Title} by {book.Author}");
                iterator.Next();
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}