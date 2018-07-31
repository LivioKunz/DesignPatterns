namespace FactoryPattern
{
    public class Vehicle
    {
        public Vehicle(double maxSpeed, int numberOfTires)
        {
            this.MaxSpeed = maxSpeed;
            this.NumberOfTires = numberOfTires;
        }

        private double MaxSpeed { get; }

        private int NumberOfTires { get; }
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