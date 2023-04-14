using System;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0; int b=0;   int c=0;
            int x;
            Console.WriteLine("Enter the three numbers");
            a=int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            x=calcgreater(a, b, c);
            Console.WriteLine("The greatest number is {0}",x);
        }
        static int calcgreater(int aa, int bb, int cc)
        {
            if( aa > bb )
            {
                if ( aa > cc )
                {
                    return aa;
                }
                else
                {
                    return cc;
                }
            }
            else if( bb > cc )
            {
                return bb;
            }
            else
            {
                return cc;
            }
            
            
        }
    }
}
