using System;
using System.Diagnostics.Eventing.Reader;

namespace account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("***********Accounts Application**********");
                Console.WriteLine("*****************************************");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account information");
                Console.WriteLine("3. Deposit amount");
                Console.WriteLine("4. Withdraw amount");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter your option: ");
            ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                case 1:
                        Console.WriteLine("Enter your Account id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your name: ");
                        String name= Console.ReadLine();
                        Console.WriteLine("Enter opening balance: ");
                        decimal balance=decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.Createaccount(id, name, balance);
                        break;
                case 2:
                        if (a != null)
                            a.Display();
                        else
                            Console.WriteLine("open account");
                        break;
                case 3:
                        if (a != null)
                            a.Deposit();
                        else
                            Console.WriteLine("open account");
                        break;
                case 4:
                        if (a != null)
                            a.Withdraw();
                        else 
                            Console.WriteLine("open amount");
                        break;




                }

            } while (ch!=0);
        }
    }
}
