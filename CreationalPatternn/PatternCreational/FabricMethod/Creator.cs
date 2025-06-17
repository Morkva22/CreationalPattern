using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FactoryMethod
{
    public abstract class CarFactory
    {
        public abstract Car CreateCar();
        
        public string DriveOperation()
        {
            var car = CreateCar();
            string result = "Factory: Car factory has just worked with " + car.Drive();
            return result;
        }
        
        public string RefuelOperation()
        {
            var car = CreateCar();
            string result = "Factory: Car factory has just worked with " + car.Refuel();
            return result;
        }
        
        public string ParkOperation()
        {
            var car = CreateCar();
            string result = "Factory: Car factory has just worked with " + car.Park();
            return result;
        }
    }
    
    public class CityCarFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new CityCar();
        }
    }
    
    public class SportCarFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new SportCar();
        }
    }
}