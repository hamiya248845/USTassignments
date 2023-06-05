using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1 { 
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineNumber = 1;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == null)
                    break;
                Console.WriteLine($"{lineNumber} {line}");
                lineNumber++;
            }
        }
    }
}