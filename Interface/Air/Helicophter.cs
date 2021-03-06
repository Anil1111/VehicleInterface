﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Helicophter : IAirVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
 
        public double MaxAirSpeed { get; set; }


   
        public void Fly()
        {
            Console.WriteLine("The Helicophter circled over us");
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
