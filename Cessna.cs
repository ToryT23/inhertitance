using System;
using System.Collections.Generic;
namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        

        public void RefuelTank()
        {
            // method definition omitted
        }
         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} vehicle makes a Zoooooom sound!");
        }
          public override void Turn(string definition)
        {
            Console.WriteLine($"The {MainColor} cessna makes wide turns ");
        }
          public override void Stop () 
        {
            Console.WriteLine("Always stops perfectly");
        }
    }
}