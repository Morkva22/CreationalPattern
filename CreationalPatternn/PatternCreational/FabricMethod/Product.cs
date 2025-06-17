using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FactoryMethod
{
    public interface ICar
    {
        string Drive();
        string Refuel();
        string Park();
    }
    
    public abstract class Car : ICar
    {
        public abstract string Drive();
        public abstract string Refuel();
        public abstract string Park();
    }
    
    class CityCar : Car
    {
        public override string Drive()
        {
            return "I drive carefully in the city at 60 km/h";
        }
        
        public override string Refuel()
        {
            return "I refuel with regular gasoline at city gas station";
        }
        
        public override string Park()
        {
            return "I park in the city parking lot";
        }
    }
    
    class SportCar : Car
    {
        public override string Drive()
        {
            return "I drive fast on the highway at 200 km/h";
        }
        
        public override string Refuel()
        {
            return "I refuel with premium gasoline at racing station";
        }
        
        public override string Park()
        {
            return "I park in the VIP garage";
        }
    }
}