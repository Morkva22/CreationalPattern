using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Proxy
{
    public class RealImage : IImage
    {
        private string _filename;
        private string _size;
        private bool _isLoaded;

        public RealImage(string filename)
        {
            _filename = filename;
            _isLoaded = false;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {_filename}");
            System.Threading.Thread.Sleep(2000);
            _size = "1920x1080";
            _isLoaded = true;
            Console.WriteLine($"Image {_filename} loaded successfully");
        }

        public void Display()
        {
            if (_isLoaded)
            {
                Console.WriteLine($"Displaying image: {_filename} [{_size}]");
            }
            else
            {
                Console.WriteLine("Image not loaded");
            }
        }

        public string GetInfo()
        {
            return $"Real Image: {_filename}, Size: {_size}, Loaded: {_isLoaded}";
        }
    }
}