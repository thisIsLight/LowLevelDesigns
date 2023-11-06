﻿using ParkingSystem.ParkingAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Interfaces
{
    public interface IParkingSpace
    {
        ParkingTickets BookSlot(IVehicle vehicle);
    }
}
