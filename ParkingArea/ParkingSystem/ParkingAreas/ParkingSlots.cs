using ParkingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.ParkingAreas
{
    public class ParkingSlots : IParkingSpace
    {
        public int ParkingSlotId;
        public IVehicle VehicleSlotType;
        public bool IsOccupied;

        public ParkingSlots(int parkingSlotId, IVehicle vehicletype)
        {
            ParkingSlotId = parkingSlotId;
            VehicleSlotType = vehicletype;
            IsOccupied = false;
        }

        public ParkingTickets BookSlot(IVehicle vehicle)
        {
            VehicleSlotType = vehicle;
            IsOccupied = true;
            return new ParkingTickets(this);
        }

        public bool FreeSlot()
        {
            IsOccupied = false;
            return true;
        }
    }
}
