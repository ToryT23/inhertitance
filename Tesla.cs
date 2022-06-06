using System;
using System.Collections.Generic;
namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
         public override void Drive()
        {
            Console.WriteLine($" The {MainColor} vehicle makes a Boom sound!");
        }
         public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} tesla has a bad right turn ");
        }
         public override void Stop()
        {
            Console.WriteLine($"The {MainColor} tesla stops slowly");
        }
    }
}