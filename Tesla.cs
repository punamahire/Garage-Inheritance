using System;

namespace Garage
{
    // Electric car
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Burgundy Tesla blazzes by you. MMmmmmmmmmmmmmm");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The burgundy Tesla carefully turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Tesla silently stops as if it nevwe moved.");
        }
        
    }
}