using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s1 = new shape();
            s1.Drawshape();

            circle c1=new circle();
            c1.Drawshape();

            shape s2 = new circle();
            s2.Drawshape();

            //array of references of base class referencing derived class object
        }
    }
}
