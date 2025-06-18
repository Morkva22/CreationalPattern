using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Momento
{
    public interface IMomento
    {
        void SetState(List<object> arg);
        List<object> GetState();
    }
    public class GameMomento : Game, IMomento
    {
        public GameMomento(int level, int health, string location) : base(level, health, location)
        {}
        public GameMomento(Game game) : base(game)
        { }
        public List<object> GetState()
        {
            return new List<object> { Level, Health, Location };
        }
        public void SetState(List<object> arg)
        {
            Level = (int)arg[0];
            Health = (int)arg[1];
            Location = (string)arg[2];
        }
        public override string ToString()
        {
            return $"Momento: Level: {Level}, Health: {Health}, Location: {Location}";
        }
    }
}