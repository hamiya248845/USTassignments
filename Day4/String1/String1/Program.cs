using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace String1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            Console.WriteLine("Enter the string:");
            String str=Console.ReadLine();
            //string rev = string.Empty;
            for(int i=str.Length-1; i>=0; i--)
            {
                Console.WriteLine(str[i]);  
            }
            
        }

        }

       
    }

