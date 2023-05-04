using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls=new List<Song>();
            Console.WriteLine("Enter the no of songs");
            int n=int.Parse(Console.ReadLine());
            
            for(int i=0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                DateTime dt = DateTime.ParseExact(s[5], "dd-MM-yyyy",null);
                
                int noofdown = int.Parse(s[4]);
                Song s1= new Song(s[0], s[1], s[2],double.Parse(s[3]),noofdown,dt);   
                ls.Add(s1);
            }

            SortedDictionary<string,int> sd= new SortedDictionary<string,int>();
            sd = Song.CalculateTypeCount(ls);
            Console.WriteLine("{0} {1,15}", "Song type", "Count");
            foreach (var s in sd)
            {
                Console.WriteLine("{0} {1,15}", s.Key,s.Value);
            }

        }
    }
}
