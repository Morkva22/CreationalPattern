using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Proxy
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _filename;
        private bool _accessGranted;

        public ProxyImage(string filename, bool accessGranted = true)
        {
            _filename = filename;
            _accessGranted = accessGranted;
        }

        public void Display()
        {
            if (!_accessGranted)
            {
                Console.WriteLine($"Access denied for image: {_filename}");
                return;
            }

            if (_realImage == null)
            {
                Console.WriteLine("Proxy: Creating real image object...");
                _realImage = new RealImage(_filename);
            }
            
            _realImage.Display();
        }

        public string GetInfo()
        {
            if (_realImage == null)
            {
                return $"Proxy Image: {_filename}, Real object not created yet, Access: {(_accessGranted ? "Granted" : "Denied")}";
            }
            return _realImage.GetInfo();
        }
    }
}