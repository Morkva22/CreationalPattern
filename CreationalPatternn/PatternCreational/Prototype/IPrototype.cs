using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
    
    public abstract class Prototype : IPrototype
    {
        public abstract IPrototype Clone();
    }
    
    public abstract class Document : Prototype
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public Document(string title, string content)
        {
            Title = title;
            Content = content;
            CreatedDate = DateTime.Now;
        }
        
        public abstract void DisplayInfo();
        public abstract override IPrototype Clone();
    }
}