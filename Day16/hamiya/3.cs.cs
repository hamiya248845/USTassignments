using System;

namespace Sort

{

    class sort

    {
        static void Main(string[] args)

        {
            int[] A = { 1, 0, 0, 1, 2, 2, 1, 0 };

            int n = A.Length;

            int c0 = 0, c1 = 0, c2 = 0;

            int i = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(A[i]);
            }

            for (i = 0; i < n; i++)
            {
                if (A[i] == 0)
                {
                    c0 += 1;
                }
                if (A[i] == 1)
                {
                    c1 += 1;
                }
                if (A[i] == 2)
                {
                    c2 += 1;
                }
            }
            for (i = 0; i < c0; i++)
            {
                A[i] = 0;
            }
            for (i = c0; i < c0 + c1; i++)
            {
                A[i] = 1;
            }

            for (i = c0 + c1; i < n; i++)
            {
                A[i] = 2;
            }

            Console.WriteLine("After sort");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}





























