using System;

namespace debugDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
           
            fun(a, a);
            Console.WriteLine("Debugging Demo");
        }
        public static void fun(int x, int y)
        {
            int t = 100;
            for (int i = x; i <= y; i++)
            {
                Console.WriteLine("india");
                t = t + 32;
            }

        }
    }
}
