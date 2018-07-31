using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Vehicle
    {
        double MaxSpeed { get; set; }

        int NumberOfTires { get; set; }

        public Vehicle(double maxSpeed, int numberOfTires)
        {
            MaxSpeed = maxSpeed;
            NumberOfTires = numberOfTires;
        }

       
    }

    public class Car : Vehicle
    {
        public Car(double maxSpeed, int numberOfTires) : base(maxSpeed, numberOfTires)
        {
        }
    }

    public class Bike : Vehicle
    {

        public Bike(double maxSpeed, int numberOfTires) : base(maxSpeed, numberOfTires)
        {
        }
    }
}
