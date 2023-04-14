using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetimeataype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to show the current date and time
            Console.WriteLine(DateTime.Now);

            DateTime dt=new DateTime(1999,05,17);
            Console.WriteLine(dt);

            Console.WriteLine(DateTime.MinValue);
        }
    }
}
