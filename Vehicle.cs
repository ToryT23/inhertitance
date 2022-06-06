using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

// To have each vehicle make its own sound,
          public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        // Create a Turn(string direction) method, and a Stop() method on Vehicle. 
        //Define a basic implementation of each.
        public virtual void Turn (string direction)
        {
            Console.WriteLine("Drive safetly, take this right");
        } 

        public virtual void Stop () 
        {
            Console.WriteLine("Stop now");
        }
    }
}