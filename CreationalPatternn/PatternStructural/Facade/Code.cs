using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Facade
{
    public class ClientCode
    {
        public void Main()
        {
            ITheaterComponent audioSystem = new AudioSystem();
            ITheaterComponent videoProjector = new VideoProjector();
            ITheaterComponent lightingSystem = new LightingSystem();

            HomeTheaterFacade facade = new HomeTheaterFacade(audioSystem, videoProjector, lightingSystem);

            Console.WriteLine(facade.StartMovie());
            Console.WriteLine();
            Console.WriteLine(facade.StopMovie());
        }
    }
}