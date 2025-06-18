using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Facade
{
    public interface ITheaterComponent
    {
        string Control(string command);
    }

    public class AudioSystem : ITheaterComponent
    {
        public string Control(string command)
        {
            return $"AudioSystem: {command}";
        }
    }

    public class VideoProjector : ITheaterComponent
    {
        public string Control(string command)
        {
            return $"VideoProjector: {command}";
        }
    }

    public class LightingSystem : ITheaterComponent
    {
        public string Control(string command)
        {
            return $"LightingSystem: {command}";
        }
    }
}