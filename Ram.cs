using System;

namespace Garage
{
    // Gas powered truck
    public class Ram : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Silver Ram growls by you. Rruuummbbbbllee");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The silver Ram carefully turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram gently rolls to a stop.");
        }
    }
}