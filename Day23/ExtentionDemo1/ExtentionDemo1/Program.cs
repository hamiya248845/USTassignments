﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            OldClass obj = new OldClass();
            obj.Test1();
            obj.Test2();
            //Calling Extension Methods
            obj.Test3();
            obj.Test4(10);
            obj.Test5();
            Console.ReadLine();
        }
    }
}
