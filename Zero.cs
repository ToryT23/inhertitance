using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
      

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($" The {MainColor} zero vehicle makes a Crack sound!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} zero has a bad {direction} turn ");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} zero must rather quickly");
        }
    }
}