﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankexception
{
    public class Program
    {
        static void Main(string[] args)
        {
         

          

                customer c = new customer("Rahul", 2453, 500);

                try

                {

                    c.withdraw(450);
                
                    Console.WriteLine("Transaction done");
                
                

                }

      catch(bankexception e)

                {

                    Console.WriteLine("Transaction Failed ");

                    e.inform();

                }
           

        }
        }

    }

