using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            var cessna = new Cessna();
            var helicophter = new Helicophter();
            List<IAirVehicle> airVehicles = new List<IAirVehicle> { cessna, helicophter };


            foreach(var a in airVehicles)
            {
                a.Fly();
            }

            var car = new Car();
            var motorcycle = new Motorcycle();
            List<ILandVehicle> landVehicles = new List<ILandVehicle> { car, motorcycle };

            foreach (var l in landVehicles)
            {
                l.Drive();
            }

            var jetski = new JetSki();
            var pantoon = new Pantoon();
            List<IWaterVehicle> waterVehicles = new List<IWaterVehicle> { jetski, pantoon };

            foreach (var w in waterVehicles)
            {
                w.Drive();
            }

            Console.ReadLine();
        }
    }
}
