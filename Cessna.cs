using System;

namespace Garage
{
     // Propellor light aircraft
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The White Cessna flashes by you lika a hurricane. Zzoooooommmmmm");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The white Cessna carefully turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna rolls down the runway for a mile and stops.");
        }
    }
}