using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface ILandVehicle : IVehicle
    {
      
        double MaxLandSpeed { get; set; }
     
        void Drive();
    
    }
}
