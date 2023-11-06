using ParkingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehicles
{
    public class TwoWheelers : IVehicle
    {
        public double GetParkingPrice()
        {
            return 20;
        }

        public string GetVehilcleType()
        {
            return "TwoWheeler";
        }
    }
}
