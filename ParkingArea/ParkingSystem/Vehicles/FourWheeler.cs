using ParkingSystem.Interfaces;

namespace ParkingSystem.Vehicles
{
    public class FourWheeler : IVehicle
    {
        public double GetParkingPrice()
        {
            return 10;
        }

        public string GetVehilcleType()
        {
            return "FourWheeler";
        }
    }
}
