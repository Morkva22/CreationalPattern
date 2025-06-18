using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Proxy
{
    public interface IImage
    {
        void Display();
        string GetInfo();
    }
}