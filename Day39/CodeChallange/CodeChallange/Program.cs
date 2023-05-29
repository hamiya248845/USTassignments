using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student type");
            string student=Console.ReadLine();
            Console.WriteLine("Enter the tuition fee");
            float tfee=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bus fee");
            float bfee=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hostel fee");
            float hfee=float.Parse(Console.ReadLine());
            double total = 0;
            double c = 1.5;
            if (student == "MSDS")
            {
                total += tfee + bfee;
                Console.WriteLine("The fees to be paid by the student is Rs.{0}",Math.Round(total,2));
            }
            else if(student == "MSH")
            {
                total += tfee + hfee;
                Console.WriteLine("The fees to be paid by the student is Rs.{0}",Math.Round(total,2));
            }
            else if( student == "MGSDS")
            {
                total += c*(tfee) + bfee;
                Console.WriteLine("The fees to be paid by the student is Rs.{0}", Math.Round(total, 2));
            }
            else if( student == "MGSH")
            {
                total += c*(tfee) + hfee;
                Console.WriteLine("The fees to be paid by the student is Rs.{0}", Math.Round(total, 2));
            }
            else
            {
                Console.WriteLine("Type invalid");
            }
        }
    }
}
