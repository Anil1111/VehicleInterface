using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IWaterVehicle : IVehicle
    {
   
        double MaxWaterSpeed { get; set; }
  

        void Drive();
       
    }
}
