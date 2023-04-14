using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter tge amount");
            int amt=int.Parse(Console.ReadLine());
            int num = amt / 2000;
            int amt1 = amt % 2000;
            int num1 = amt1 / 1000;
            int amt2 = amt1 % 1000;
            int num2 = amt2 / 500; 
            int amt3 = amt2 % 500;
            int num3 = amt3 / 100;
            int amt4=  amt3 % 100;    
            int num4 = amt4 / 10;
            int amt5= amt4 % 10;
            int num5 = amt5 / 5;
            int amt6 = amt5 % 5;
            Console.WriteLine("2000: {0} 1000: {1} 500: {2} 100: {3} 10: {4} 5: {5}", num, num1, num2, num3, num4,num5);            


        }
    }
}
