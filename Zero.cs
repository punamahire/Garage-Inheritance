using System;

namespace Garage
{
    // Electric motorcycle
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Midnight Zero zips by you. Yeeeeoooooowwwwww");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The midnight Zero carefully turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Zero gently rolls to a stop.");
        }
        
    }
}