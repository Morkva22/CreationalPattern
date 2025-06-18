using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Flyweight
{
    public enum CharacterClass
    {
        Warrior,
        Mage,
        Archer
    }

    public class CharacterTypeFactory
    {
        private static Dictionary<CharacterClass, ICharacterType> _characterTypes = new Dictionary<CharacterClass, ICharacterType>();

        public static ICharacterType GetCharacterType(CharacterClass characterClass)
        {
            if (!_characterTypes.ContainsKey(characterClass))
            {
                switch (characterClass)
                {
                    case CharacterClass.Warrior:
                        _characterTypes[characterClass] = new WarriorType();
                        break;
                    case CharacterClass.Mage:
                        _characterTypes[characterClass] = new MageType();
                        break;
                    case CharacterClass.Archer:
                        _characterTypes[characterClass] = new ArcherType();
                        break;
                }
                Console.WriteLine($"Created new {characterClass} flyweight");
            }
            return _characterTypes[characterClass];
        }

        public static int GetCreatedFlyweightsCount()
        {
            return _characterTypes.Count;
        }
    }
}