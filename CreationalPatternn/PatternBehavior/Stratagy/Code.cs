using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    public class ClientCode
    {
        public void Main()
        {
            Dictionary<string, Animal> animals = new Dictionary<string, Animal>
            {
                { "Bird", new Animal(new BirdMoveStrategy(), "Eagle", "Wings", "Feathers") },
                { "Fish", new Animal(new FishMoveStrategy(), "Shark", "Fins", "Scales") },
                { "Mammal", new Animal(new MammalMoveStrategy(), "Lion", "Legs", "Fur") }
            };

            Console.WriteLine(animals["Bird"].StartMoving());
            Console.WriteLine(animals["Fish"].StartMoving());
            Console.WriteLine(animals["Mammal"].StartMoving());

            Console.WriteLine(animals["Bird"].IsMoving());
            Console.WriteLine(animals["Fish"].IsMoving());
            Console.WriteLine(animals["Mammal"].IsMoving());

            Console.WriteLine(animals["Bird"].StopMoving());
            Console.WriteLine(animals["Fish"].StopMoving());
            Console.WriteLine(animals["Mammal"].StopMoving());

            Console.WriteLine(animals["Bird"].IsMoving());
            Console.WriteLine(animals["Fish"].IsMoving());
            Console.WriteLine(animals["Mammal"].IsMoving());
        }
    }
}