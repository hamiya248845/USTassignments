using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace PowerOfTwo

{
    class Solution
    {
        class InnerPrivate
        {
            int rem;
            public void powerof2(int num)
            {
                if (num == 1)
                    Console.Write("It is power of 2.");
                else
                {
                    while (num > 1)
                    {
                        rem = num % 2;
                        if (rem != 0)
                            break;
                        num /= 2;
                    }
                    if (num == 1)
                        Console.WriteLine("It is a power of 2");
                    else
                        Console.WriteLine("It is not a power of 2");
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number to check");
                int num = Convert.ToInt32(Console.ReadLine());
                Solution.InnerPrivate ip = new Solution.InnerPrivate();
                ip.powerof2(num);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

}