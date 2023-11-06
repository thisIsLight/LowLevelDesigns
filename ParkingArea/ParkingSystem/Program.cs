using ParkingSystem.ParkingAreas;
using ParkingSystem.Vehicles;

namespace ParkingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating Slots
            List<ParkingSlots> slots = new List<ParkingSlots>();
            for (var i = 0; i < 10; i++)
            {
                ParkingSlots slot;
                if (i < 5)
                {
                    var vehicleType = new TwoWheelers();
                    slot = new ParkingSlots(i, vehicleType);
                }
                else
                {
                    var vehicleType = new FourWheeler();
                    slot = new ParkingSlots(i, vehicleType);
                }
                slots.Add(slot);
            }

            //Creating Parking Space
            var ParkingSpace = new ParkingSpaces(slots);

            //Creating Parking System
            var system = new ParkingSystem(ParkingSpace);

            //1st 2 wheeler
            var t1 = system.BookSlot(new TwoWheelers());
            var t2 = system.BookSlot(new TwoWheelers());
            var t3 = system.BookSlot(new FourWheeler());
            var t4 = system.BookSlot(new TwoWheelers());
            var t5 = system.BookSlot(new TwoWheelers());
            var t6 = system.BookSlot(new TwoWheelers());
            var t7 = system.BookSlot(new TwoWheelers());

            var price = system.Exit(t4);
        }
    }
}
           
        
    
