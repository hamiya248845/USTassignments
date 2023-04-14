using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            int age=int.Parse(Console.ReadLine()); 
            if(age >= 18)
            {
                Console.WriteLine("Eligible for voting");
            }
            else
            {
                Console.WriteLine("Not eligible for voting");
            }
        }
    }
}
