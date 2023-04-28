using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace delegateDemo
{
    class Program
    {
        static void Add(int i,int j)
        {
            Console.WriteLine("Sum: " + (i + j));
        }
        static void Sub(int i,int j)
        {
            Console.WriteLine("sub: "+ (i-j));
        }
        public delegate void reftomethod(int i, int j);
        static void Main(string[] args)
        {
            //Add(10, 20);
            reftomethod r1 = Add;
            r1(10, 20);
            reftomethod r2 = Sub;
            r2.Invoke(20, 10);



            //reftomethod multicast = Add;
            //multicast += Sub;
            //multicast(20, 10);


        }
    }
}
