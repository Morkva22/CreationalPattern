using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Proxy
{
    public class ClientCode
    {
        public void Main()
        {
            Console.WriteLine("=== Creating proxy images ===");
            IImage image1 = new ProxyImage("vacation_photo.jpg", true);
            IImage image2 = new ProxyImage("secret_document.png", false);
            IImage image3 = new ProxyImage("family_portrait.jpg", true);

            Console.WriteLine("\n=== Getting info without loading ===");
            Console.WriteLine(image1.GetInfo());
            Console.WriteLine(image2.GetInfo());
            Console.WriteLine(image3.GetInfo());

            Console.WriteLine("\n=== First display attempts ===");
            Console.WriteLine("Displaying image1:");
            image1.Display();

            Console.WriteLine("\nDisplaying image2 (access denied):");
            image2.Display();

            Console.WriteLine("\n=== Second display (no loading) ===");
            Console.WriteLine("Displaying image1 again:");
            image1.Display();

            Console.WriteLine("\n=== Final info ===");
            Console.WriteLine(image1.GetInfo());
            Console.WriteLine(image2.GetInfo());
        }
    }
}