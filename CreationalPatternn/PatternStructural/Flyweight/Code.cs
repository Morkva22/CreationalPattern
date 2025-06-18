using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Flyweight
{
    public class ClientCode
    {
        public void Main()
        {
            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(new GameCharacter(10, 15, "Player1", CharacterClass.Warrior));
            characters.Add(new GameCharacter(25, 30, "Player2", CharacterClass.Mage));
            characters.Add(new GameCharacter(40, 50, "Player3", CharacterClass.Archer));
            characters.Add(new GameCharacter(60, 70, "Player4", CharacterClass.Warrior));
            characters.Add(new GameCharacter(80, 90, "Player5", CharacterClass.Mage));
            characters.Add(new GameCharacter(100, 110, "Player6", CharacterClass.Warrior));

            Console.WriteLine("=== Rendering all characters ===");
            foreach (var character in characters)
            {
                character.Render();
            }

            Console.WriteLine($"\nTotal flyweights created: {CharacterTypeFactory.GetCreatedFlyweightsCount()}");
            Console.WriteLine($"Total characters: {characters.Count}");

            Console.WriteLine("\n=== Moving characters ===");
            characters[0].Move(15, 20);
            characters[1].Move(30, 35);

            Console.WriteLine("Rendering after move:");
            characters[0].Render();
            characters[1].Render();
        }
    }
}