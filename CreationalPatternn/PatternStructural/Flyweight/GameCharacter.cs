using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Flyweight
{
    public class GameCharacter
    {
        private int _x;
        private int _y;
        private string _playerName;
        private ICharacterType _characterType;

        public GameCharacter(int x, int y, string playerName, CharacterClass characterClass)
        {
            _x = x;
            _y = y;
            _playerName = playerName;
            _characterType = CharacterTypeFactory.GetCharacterType(characterClass);
        }

        public void Move(int newX, int newY)
        {
            _x = newX;
            _y = newY;
        }

        public void Render()
        {
            _characterType.Render(_x, _y, _playerName);
        }
    }
}