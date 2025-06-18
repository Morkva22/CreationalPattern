using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Momento
{
    public class Game
    {
        public int Level { get; set; }
        public int Health { get; set; }
        public string Location { get; set; }
        public Game(int level, int health, string location)
        {
            Level = level;
            Health = health;
            Location = location;
        }
        public Game(Game game)
        {
            this.Level = game.Level;
            this.Health = game.Health;
            this.Location = game.Location;
        }
        public void SetState(int level, int health, string location)
        {
            Level = level;
            Health = health;
            Location = location;
        }
        public void ShowState()
        {
            Console.WriteLine($"Level: {Level}, Health: {Health}, Location: {Location}");
        }
        public GameMomento SaveState()
        {
            return new GameMomento(Level, Health, Location);
        }
        public void RestoreState(GameMomento momento)
        {
            var arg = momento.GetState();
            Level = (int)arg[0];
            Health = (int)arg[1];
            Location = (string)arg[2];
        }
        public override string ToString()
        {
            return $"Origin: Level: {Level}, Health: {Health}, Location: {Location}";
        }
    }
}