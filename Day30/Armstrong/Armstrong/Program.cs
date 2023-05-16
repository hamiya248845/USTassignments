using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            int armstrong = Calculatearmstrong(n);
            if(armstrong == n) 
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

         static int Calculatearmstrong(int n1)
        {
            
            int r=0;
            int arm = 0;
            while(n1>0)
            {
                r=n1%10;
                arm += r * r * r;
                n1=n1/10;
            }
            
            return arm;
        }
    }
}
