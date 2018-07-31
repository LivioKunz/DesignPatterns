using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleCharter
    {
        public static void Main(string[] args)
        {


            Vehicle bike = VehicleFactory.GetVehicle("bike");
            Vehicle car = VehicleFactory.GetVehicle("car");
        }
    }
}
