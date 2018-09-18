using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class JetSki : IVehicle, IWaterVehicle
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
            Console.WriteLine("The jetSki zips through the waves with the greteds of ease"); ;
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
