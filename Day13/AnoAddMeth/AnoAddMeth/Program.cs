using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public delegate int Add(int x,int y);
    class Program
    {
        static void Main(string[] args)
        {
        int result;
            Add sum = delegate(int n,int m)
            {
               
                return n+m;
            };
            result=sum(10,20);
        Console.WriteLine(result);
    }
    }

