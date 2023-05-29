using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter the first word");
                string w1 = Console.ReadLine();
                Console.WriteLine("Enter the second word");
                string w2 = Console.ReadLine();
                char[] ch1 = w1.ToLower().ToCharArray();
                char[] ch2 = w2.ToLower().ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string s1=new string(ch1);
                string s2=new string(ch2);
            if (s1 == s2)
            {
                Console.WriteLine("Anagrams");
            }
            else
            {
                Console.WriteLine("Not Anagrams");
            }
        }
    }
}

