using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    public class Car
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }

        public void StopCar()
        {

        }

        public void StartCar()
        {

        }
    }

    public class Corrola : Car
    {

    }
}
