using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           //List<Member> li=new List<Member>();
                Console.WriteLine("Member1");
                Console.WriteLine("id:");
                long id = long.Parse(Console.ReadLine());
                Console.WriteLine("first name:");
                string fname =Console.ReadLine();
                Console.WriteLine("last name:");
                string lname = Console.ReadLine();
                Console.WriteLine("email");
                string email = Console.ReadLine();
                Console.WriteLine("contact number");
                string phone = Console.ReadLine();
                Console.WriteLine("license number");
                string lnumber = Console.ReadLine();
                Console.WriteLine("license start date");
                DateTime startdate= DateTime.Parse(Console.ReadLine());
                Console.WriteLine("license expiry date");
                DateTime expirydate= DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Member2");
            Console.WriteLine("id:");
            long id2 = long.Parse(Console.ReadLine());
            Console.WriteLine("first name:");
            string fname2 = Console.ReadLine();
            Console.WriteLine("last name:");
            string lname2 = Console.ReadLine();
            Console.WriteLine("email");
            string email2 = Console.ReadLine();
            Console.WriteLine("contact number");
            string phone2 = Console.ReadLine();
            Console.WriteLine("license number");
            string lnumber2 = Console.ReadLine();
            Console.WriteLine("license start date");
            DateTime startdate2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("license expiry date");
            DateTime expirydate2 = DateTime.Parse(Console.ReadLine());

            Member member1 = new Member(id, fname, lname,email,phone,lnumber,startdate,expirydate);
            Member member2 = new Member(id2, fname2, lname2, email2, phone2, lnumber2, startdate2, expirydate2);

            Console.WriteLine(member1);
            Console.WriteLine(member2);

            if (member1.Equals(member2))
            {
                Console.WriteLine("Member1 is same as Member2");
            }
            else
                Console.WriteLine("Member1 and Member2 are different");
        }
        }
    }

