using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Cessna : IAirVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxAirSpeed { get; set; } = 160.4;


        public void Fly()
        {
            Console.WriteLine("The Cessna sounds smooth on the highway"); ;
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

