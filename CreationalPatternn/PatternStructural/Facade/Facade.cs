using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Facade
{
    public class HomeTheaterFacade
    {
        private ITheaterComponent _audioSystem;
        private ITheaterComponent _videoProjector;
        private ITheaterComponent _lightingSystem;

        public HomeTheaterFacade(ITheaterComponent audioSystem, ITheaterComponent videoProjector, ITheaterComponent lightingSystem)
        {
            _audioSystem = audioSystem;
            _videoProjector = videoProjector;
            _lightingSystem = lightingSystem;
        }

        public string StartMovie()
        {
            return $"Starting movie experience:\n{_audioSystem.Control("Power On")}\n{_videoProjector.Control("Turn On")}\n{_lightingSystem.Control("Dim Lights")}";
        }

        public string StopMovie()
        {
            return $"Ending movie experience:\n{_audioSystem.Control("Power Off")}\n{_videoProjector.Control("Turn Off")}\n{_lightingSystem.Control("Bright Lights")}";
        }
    }
}