using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Pantoon : IVehicle, IWaterVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        


        public void Drive()
        {
            Console.WriteLine("Floating ridges are roadways carried on pontoons moored in a stream."); ;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

    }

}

