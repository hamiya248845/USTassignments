using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,string> s = new SortedList<string, string>();
            //generics <string....  if not 
            s.Add("Maharastra  ", "Mumbai");
            s.Add("Kerals      ", "Tvm");
            s.Add("Bihar       ", "Patna");

            Console.WriteLine("sortedlist:");
            foreach (var item in s.Keys)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("\t");
            foreach (var item in s.Values)
            {

                Console.WriteLine(item);
            }
        }
    }
}
