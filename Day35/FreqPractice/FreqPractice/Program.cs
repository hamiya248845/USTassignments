using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] array=new int[n];
            for(int i=0; i<n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> freq = countFreq(array);
            foreach (var pair in freq)
            {
                Console.WriteLine($"{pair.Key} occures {pair.Value}");
            }
            
        }

        private static Dictionary<int, int> countFreq(int[] array)
        {
            Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item]++;
                }
                else
                {
                    keyValuePairs[item] = 1;
                }
                
            }
            return keyValuePairs;
        }
    }
}
