using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 56,4,89,1,7 };
            int temp;
            for(int i=0; i<array.Length-1; i++)
            {
                for(int j=0; j<array.Length-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j]= array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for(int i=0;i<array.Length; i++)
            {
                Console.Write(array[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
