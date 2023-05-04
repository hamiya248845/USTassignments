using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missing_num
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int missingnum = Findnum(n, arr);
            Console.WriteLine(missingnum);
        }

            public static int Findnum(int N, int[] a)
            {
                int sum1 = (N * (N + 1)) / 2;
                int sum2 = 0;
                foreach (int i in a)
                {
                    sum2 += i;

                }
                int value = sum1 - sum2;
                return value;
            }
        }
    }

