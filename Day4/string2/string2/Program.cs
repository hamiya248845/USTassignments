using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace string2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str=Console.ReadLine();
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'A' || str[i] == 'e' || str[i] == 'E' || str[i] == 'i' || str[i] == 'I' || str[i] == 'o' || str[i] == 'O' || str[i] == 'u' || str[i] == 'U')
                {
                    count++;
                }
                else if (str[i] >= 'a' && str[i] <='z' || str[i] >='A' && str[i] <='Z' || str[i] >= 'a' && str[i]<='Z')
                {
                    count2++;
                }
                
            }
            Console.WriteLine("No of vowels={0} and no of consonents={1}", count, count2);
        }
    }
}
