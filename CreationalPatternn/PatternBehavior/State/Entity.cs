using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    public class Player : StaticCharacter
    {
        public override void Build()
        {
            Console.WriteLine($"Player is built with value {_value}.");
        }

        public override void Dispose()
        {
            Console.WriteLine("Player is disposed.");
        }

        public override void InitState(string value)
        {
            _value = value;
            Console.WriteLine($"Player is initialized with value {_value}.");
        }

        public override void SetState(string value)
        {
            base.SetState(value);
        }
    }

    public class Monster : DynamicCharacter
    {
        public override void Build()
        {
            Console.WriteLine($"Monster is built with value {_value}.");
        }

        public override void Dispose()
        {
            Console.WriteLine("Monster is disposed.");
        }

        public override void InitState(string value)
        {
            _value = value;
            Console.WriteLine($"Monster is initialized with value {_value}.");
        }

        public override void SetState(string value)
        {
            _value = value;
            Console.WriteLine($"Monster is set with value {_value}.");
        }
    }
}