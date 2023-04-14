using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            char c= ' ';
            int count = 0;
            int max = 0;
            
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == ' ')
                    continue; //to ignore spaces
                for(int j=i+1; j<str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }

                }
                if (count > max)
                {
                    max = count;
                    c= str[i];
                }
            }
            Console.WriteLine("The character {0} is max occured and it occures {1} times",c,max);
        }
    }
}
