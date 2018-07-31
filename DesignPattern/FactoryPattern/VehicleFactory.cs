using System;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static Vehicle GetVehicle(string vehicleName)
        {
            if (vehicleName.Equals("car", StringComparison.InvariantCultureIgnoreCase)) return new Car(5, 4);
            if (vehicleName.Equals("bike", StringComparison.InvariantCultureIgnoreCase)) return new Bike(200, 2);
            return new Vehicle(0, 0);
        }
    }
}