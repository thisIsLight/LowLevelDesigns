using ParkingSystem.Interfaces;

namespace ParkingSystem.ParkingAreas
{
    public class ParkingSpaces : IParkingSpace
    {
        public List<ParkingSlots> ParkingSlotList { get; set; }

        public ParkingSpaces(List<ParkingSlots> slots)
        {
            ParkingSlotList = new List<ParkingSlots>();
            ParkingSlotList = slots;
        }

        public ParkingTickets BookSlot(IVehicle vehicle)
        {
            foreach (var slot in ParkingSlotList)
            {
                if (!slot.IsOccupied && slot.VehicleSlotType.GetType().Name.Equals(vehicle.GetType().Name))
                {
                    return slot.BookSlot(vehicle);
                }
            }
            return new ParkingTickets(null);
        }
    }
}
