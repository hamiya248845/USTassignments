using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancedemo
{
    internal class Program

    {
        static void Main(string[] args)
        {
            fruits obj = new fruits(101, "Blood orange");
            obj.display();
            orange obj1 = new orange(101, "Blood orange", "Maharashtra");
            obj1.print();


        }
        class fruits
        {
            private int _no;
            public int No 
            { get { return _no; } 
              set { _no = value; }
            }

            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public fruits() 
            {

            }

            public fruits(int no,string name) 
            { 
                _no = no;   
                _name = name;
            }

            public void display()
            {
                Console.WriteLine("Fruit no is {0}",_no);
                Console.WriteLine("Fruit bame is {0}",_name);
                //assignment of condition given at set of _name
            }
        }
        class orange : fruits
        {
            private String _origin;
            String[] origins = { "Himachal", "Maharashtra", "Telungana" };
            public String Origin
            {
                get { return _origin; }
                set
                {
                    if (Array.BinarySearch(origins, value) >= 0)
                        _origin = value;
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                }
            }
                public orange(int no,String name,String origin): base(no,name)
            {
                _origin = origin;
            }
            public void print()
            {
                base.display();
                Console.WriteLine("The origin of fruit is {0}", _origin);
            }
        }
        }
       
    }

