using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
            BatteryKWh = 22.21,
            MainColor = "Red",
            MaximumOccupancy = 4
            };
          

            Tesla modelS = new Tesla()
            {
            BatteryKWh = 23.41,
            MainColor = "Blue",
            MaximumOccupancy = 4
            };

            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 39,
                MainColor =  "Purple",
                MaximumOccupancy = 4
            };

            Ram md300 = new Ram()
            {
                FuelCapacity = 21,
                MainColor = "Black",
                MaximumOccupancy = 4
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            md300.Drive();

            fxs.Turn("bad");
            modelS.Turn("");
            mx410.Turn("");
            md300.Turn("");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            md300.Stop();

        }
    }
}