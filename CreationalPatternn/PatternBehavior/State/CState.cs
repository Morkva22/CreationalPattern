using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    public class StaticCharacter : State<string>
    {
        protected string _value;

        public override void Build()
        {
            Console.WriteLine($"Character is built with {_value}");
        }

        public override void Dispose()
        {
            Console.WriteLine("Character is disposed.");
        }

        public override void InitState(string value)
        {
            _value = value;
            Console.WriteLine($"Character is initialized with value {value}.");
        }

        public override void SetState(string value)
        {
            Console.WriteLine($"Character can`t change type!");
        }
    }

    public class DynamicCharacter : State<string>
    {
        protected string _value;

        public override void Build()
        {
            Console.WriteLine($"Character is built with value {_value}.");
        }

        public override void Dispose()
        {
            Console.WriteLine("Character is disposed.");
        }

        public override void InitState(string value)
        {
            _value = value;
            Console.WriteLine($"Character is initialized with value {_value}.");
        }

        public override void SetState(string value)
        {
            _value = value;
            Console.WriteLine($"Character is set with value {_value}.");
        }
    }
}