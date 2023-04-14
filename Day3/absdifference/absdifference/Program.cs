using System;

namespace absdifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 51;
            int abs;
            //get value of a from user

            Console.WriteLine("Enter the number");
            a = int.Parse(Console.ReadLine());
            abs = Calcabsdiff(a, b);
            Console.WriteLine("The value is:{0}", abs);
        }

        static int Calcabsdiff(int aa, int bb)
        {
            if (aa == bb)
            {
                return 0;
            }
            if (aa > bb)
            {
                return 3 * (aa - bb);
            }
            else
            {
                return 3 * (bb - aa);
            }
        }
    }
}
