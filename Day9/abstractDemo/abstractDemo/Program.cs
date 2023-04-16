using System;

namespace abstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            figure fig = new square();
            fig.dimension = 2;
            Console.WriteLine("Area " + fig.Area());
            Console.WriteLine("Perimeter " + fig.Perimeter());

            
            figure fig1 = new circle();
            fig1.dimension = 2;
            Console.WriteLine("Area " + fig1.Area());
            Console.WriteLine("Perimeter " + fig1.Perimeter());
        }
    }
}
