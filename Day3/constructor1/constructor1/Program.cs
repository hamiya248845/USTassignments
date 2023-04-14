using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the id and name: ");
            int id=int.Parse(Console.ReadLine());
            String name=Console.ReadLine();
            Emp e1 = new Emp(id,name);
            Console.WriteLine(e1.id);
            Console.WriteLine(e1.name);
        }
    }
}
