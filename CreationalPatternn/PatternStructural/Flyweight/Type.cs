using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Flyweight
{
    public interface ICharacterType
    {
        void Render(int x, int y, string playerName);
    }

    public class WarriorType : ICharacterType
    {
        private string _sprite;
        private string _abilities;

        public WarriorType()
        {
            _sprite = "warrior_sprite.png";
            _abilities = "Sword Attack, Shield Block";
        }

        public void Render(int x, int y, string playerName)
        {
            Console.WriteLine($"Rendering Warrior [{playerName}] at ({x}, {y}) with sprite: {_sprite}, abilities: {_abilities}");
        }
    }

    public class MageType : ICharacterType
    {
        private string _sprite;
        private string _abilities;

        public MageType()
        {
            _sprite = "mage_sprite.png";
            _abilities = "Fireball, Heal";
        }

        public void Render(int x, int y, string playerName)
        {
            Console.WriteLine($"Rendering Mage [{playerName}] at ({x}, {y}) with sprite: {_sprite}, abilities: {_abilities}");
        }
    }

    public class ArcherType : ICharacterType
    {
        private string _sprite;
        private string _abilities;

        public ArcherType()
        {
            _sprite = "archer_sprite.png";
            _abilities = "Arrow Shot, Quick Step";
        }

        public void Render(int x, int y, string playerName)
        {
            Console.WriteLine($"Rendering Archer [{playerName}] at ({x}, {y}) with sprite: {_sprite}, abilities: {_abilities}");
        }
    }
}