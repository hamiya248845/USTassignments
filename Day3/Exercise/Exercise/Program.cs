using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the distance in km:");
            double distance=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time in hours");
            double time=double.Parse(Console.ReadLine());
            double speed = CalcDistance(distance, time);
            Console.WriteLine("Speed in km/hour: {0}",speed);
            Console.WriteLine("Speed in miles/hour: {0}", speed*0.62);
        }

       

        static double CalcDistance(double Distance, double Time)
        {
            return Distance / Time;
        }

    }
}
