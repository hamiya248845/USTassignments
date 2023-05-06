using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dalia", "sunflower", "rose", "daisy", "daffodil" };

            var fquery=
                from flower in flowers
                where (flower.StartsWith("d")) 
                select flower;

            foreach (string f in fquery)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("\t");
            var lquery=from l in flowers
                       let len=l.Length
                       where len>5 && len<10
                       select l;
            foreach (var i in lquery)
            {
                Console.WriteLine(i);
            }


        }
    }
}
