using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Composite
{
    public class ClientCode
    {
        public void Main()
        {
            Song song1 = new Song("Bohemian Rhapsody", 355);
            Song song2 = new Song("Stairway to Heaven", 482);
            Song song3 = new Song("Hotel California", 391);

            Playlist rockPlaylist = new Playlist("Classic Rock");
            rockPlaylist.Add(song1);
            rockPlaylist.Add(song2);

            Playlist mainPlaylist = new Playlist("My Music");
            mainPlaylist.Add(rockPlaylist);
            mainPlaylist.Add(song3);

            Console.WriteLine("=== Playing individual song ===");
            song1.Play();
            Console.WriteLine($"Duration: {song1.GetDuration()} seconds");

            Console.WriteLine("\n=== Playing playlist ===");
            mainPlaylist.Play();
            Console.WriteLine($"Total duration: {mainPlaylist.GetDuration()} seconds");
        }
    }
}