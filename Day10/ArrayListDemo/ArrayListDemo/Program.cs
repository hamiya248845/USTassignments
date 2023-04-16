using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr=new ArrayList();
            arr.Add(1);
            arr.Add("name");
            arr.Add(true);
            arr.Add(3534M);
            arr.Add(45.6f);

            foreach(object obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
