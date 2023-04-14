using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length");
            int size=int.Parse(Console.ReadLine());
            int temp;
            int[] array=new int[size];
            Console.WriteLine("Enter the numbers");
            for(int i=0; i<size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //for(int i=0; i<size;i++)
            //{
            //    Console.Write(array[i]+" ");
            //}
            // srelection sort

            for(int i=0; i < size-1; i++)
            {
                for(int j=i+1; j<size; j++)
                {
                    if(array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array is:");
            for(int i=0; i < size; i++)
            {
                Console.Write(array[i] +"\t");
            }
            Console.WriteLine();
        }
    }
}
