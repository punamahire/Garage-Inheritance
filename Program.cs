using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero z = new Zero();
            Tesla t = new Tesla();
            Cessna c = new Cessna();
            Ram r = new Ram();

            z.Drive();
            z.Turn("right");
            z.Stop();
            Console.WriteLine();

            t.Drive();
            t.Turn("left");
            t.Stop();
            Console.WriteLine();

            c.Drive();
            c.Turn("right");
            c.Stop();
            Console.WriteLine();

            r.Drive();
            r.Turn("left");
            r.Stop();
        }
    }
}
    