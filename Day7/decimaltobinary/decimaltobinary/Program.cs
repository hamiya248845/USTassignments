using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaltobinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number");
            String number=Console.ReadLine();
            //string to int datatype
            int num = Convert.ToInt32(number);
            String finalnum = " ";
            while(num > 0) 
            {
                int rem = num % 2;
                //finalsum last so that it will give reverse number
                finalnum = rem.ToString()+finalnum;
                num =num / 2;
                
            }
            Console.Write(finalnum);

        }
            
        }
    }

