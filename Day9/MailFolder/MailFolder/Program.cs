using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolder
{
    public class Program
    {
        static void Main(string[] args)
        {


            for (int k = 1; k <= 2; k++)
            {
                Console.WriteLine($"Enter the mail {k} details", k + 1);
                string input = Console.ReadLine();
                string[] i = input.Split(',');
                Mail mail = new Mail(long.Parse(i[0]), i[1], i[2], i[3], i[4], DateTime.Parse(i[5]), double.Parse(i[6]));

                //Console.WriteLine(mail1);

                string[] inputs = input.Split(',');
                Console.WriteLine(mail);
            }

            if ()
                {
                    Console.WriteLine("Mail is same as mail2");
                }
                else
                    Console.WriteLine("Mail1 is not same as mail2");
            
            //if (Mail.Equals(Mail))
            //{
            //    Console.WriteLine("Mail is same as mail2");
            //}
            //else
            //    Console.WriteLine("Mail1 is not same as mail2");

        }
    }
}
