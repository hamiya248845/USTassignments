using System;
using System.Security.AccessControl;

namespace calcArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            double area;
            // get the radius
            Console.WriteLine("Enter the radius");
            r=double.Parse(Console.ReadLine());
            area = CalcArea(r);
            Console.WriteLine($"Area of the circle having radius {r} is {area}");
            // Console.WriteLine("Area of the circle having radius {0} is {1}",r,area);

        }
        // static is used since no obj is used, only function
        static double CalcArea(double rr)
        {
            double area = 0;
            area = 3.14 * rr * rr;
            return area;
            // return 3.14*rr*rr;

        }
    }
}
