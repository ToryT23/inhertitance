using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram: Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
     
        public void RefuelTank()
        {
            // method definition omitted
        }
         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} vehicle makes a honk sound!");
        }
           public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} cessna makes narrow turns ");
        }
           public override void Stop () 
        {
            Console.WriteLine("Always stops perfectly");
        }
    }
}