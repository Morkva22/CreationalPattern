using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Composite
{
    public abstract class MusicComponent
    {
        public string Name { get; set; }

        public MusicComponent(string name)
        {
            Name = name;
        }

        public abstract void Play();
        public abstract int GetDuration();

        public virtual void Add(MusicComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MusicComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual MusicComponent GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }

    public class Song : MusicComponent
    {
        private int _duration;

        public Song(string name, int duration) : base(name)
        {
            this._duration = duration;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing song: {Name} ({_duration} seconds)");
        }

        public override int GetDuration()
        {
            return _duration;
        }
    }

    public class Playlist : MusicComponent
    {
        private List<MusicComponent> _components = new List<MusicComponent>();

        public Playlist(string name) : base(name)
        {
        }

        public override void Add(MusicComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(MusicComponent component)
        {
            _components.Remove(component);
        }

        public override MusicComponent GetChild(int index)
        {
            return _components[index];
        }

        public override void Play()
        {
            Console.WriteLine($"Playing playlist: {Name}");
            foreach (var component in _components)
            {
                component.Play();
            }
        }

        public override int GetDuration()
        {
            int totalDuration = 0;
            foreach (var component in _components)
            {
                totalDuration += component.GetDuration();
            }
            return totalDuration;
        }
    }
}
