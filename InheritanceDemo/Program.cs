using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Backwards();
            car.Forwards();
            car.EngineSize = "500ci";
            car.NumberOfDoors = 4;
            car.NumberOfWheels = 4;
            car.UseSteeringWheel();

            Boat boat = new Boat();
            boat.Backwards();
            boat.Forwards();
            boat.EngineSize = "1000cc";
            boat.UseSteeringWheel();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Backwards();
            motorcycle.Forwards();
            motorcycle.EngineSize = "450ci";
            motorcycle.UseHandlebars();

            Vehicle vehicle = new Vehicle();
            vehicle.Backwards();
            vehicle.Forwards();
            vehicle.EngineSize = "";
            Console.ReadLine();
        }
    }
}
