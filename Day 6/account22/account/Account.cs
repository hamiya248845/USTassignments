using System;
using System.Runtime.InteropServices;

namespace bankApplication
{
    public class Account

    {
        public int Id;

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("Name too long....!");
                _name = value;
            }

        }
        
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        
        public void Createaccount(int id, string _name, decimal _balance)
        {
             Id=id;
            Name=_name;
           Balance=_balance;
        }

        public void Display()
        {
            Console.WriteLine(Id);
            Console.WriteLine(_name);
            Console.WriteLine(_balance);

        }

        public void Deposit()
        {
            Console.WriteLine("Enter amount");
            decimal amt=decimal.Parse(Console.ReadLine());
            Balance += amt;
            Console.WriteLine(Balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount");
            decimal amount=decimal.Parse(Console.ReadLine());
            if (Balance - amount < 0)
                Console.WriteLine("Insufficient amount");
            else
               this.Balance -= amount;
            Console.WriteLine("Balace amount {0}",Balance);
        }
    }
}