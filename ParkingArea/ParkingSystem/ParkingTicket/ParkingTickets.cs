using ParkingSystem.ParkingAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    public class ParkingTickets
    {
        public ParkingSlots? ParkingSlot { get; set; }
        
        public ParkingTickets(ParkingSlots parkingSlot) { 
            ParkingSlot = parkingSlot;
        }

        public double Exit()
        {
            if (ParkingSlot == null) return 0;
            ParkingSlot.FreeSlot();
            return ParkingSlot.VehicleSlotType.GetParkingPrice();
        }
    }
}
