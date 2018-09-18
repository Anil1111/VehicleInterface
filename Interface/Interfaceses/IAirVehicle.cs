using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IAirVehicle : IVehicle
    {
        double MaxAirSpeed { get; set; }

        void Fly();
    }
}
