using ParkingSystem.Interfaces;
using ParkingSystem.ParkingAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    public class ParkingSystem
    {
        public IParkingSpace Space { get; set; }

        public ParkingSystem(IParkingSpace space)
        {
            Space = space;
        }

        public ParkingTickets BookSlot(IVehicle vehicle)
        {
            return Space.BookSlot(vehicle);
        }

        public double Exit(ParkingTickets ticket)
        {
            return ticket.Exit();
        }
    }
}
