using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SUMOFINT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int sum;
            Console.WriteLine("Enter the two numbers");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            sum=Calcsum(a,b);
            Console.WriteLine("sum = {0}", sum);
        }
        static int Calcsum(int aa,int bb)
        {
            if (aa == bb)
            {
                return 3*(aa + bb);
            }
            else
            {
                return aa + bb;
            }
        }
    }
}
