using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    public class Animal
    {
        public Strategy MovementStrategy { get; set; }
        public string Name { get; set; }
        public string BodyPart { get; set; }
        public string Covering { get; set; }

        public Animal(Strategy movementStrategy, string name, string bodyPart, string covering)
        {
            MovementStrategy = movementStrategy;
            Name = name;
            BodyPart = bodyPart;
            Covering = covering;
        }

        public bool IsMoving()
        {
            return MovementStrategy.IsMoving(Name);
        }

        public string StartMoving()
        {
            return MovementStrategy.StartMoving(Name, BodyPart, Covering);
        }

        public string StopMoving()
        {
            return MovementStrategy.StopMoving(Name, BodyPart, Covering);
        }
    }
}