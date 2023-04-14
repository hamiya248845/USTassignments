using System;

namespace account
{
    public class Account
    {
        public int id;
        public string name;
        public decimal balance;
        internal object display;

        public void Createaccount(int Id, string Name, decimal Balance)
        {
            id=Id;
            name=Name;
            balance=Balance;
        }

        public void Display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(balance);

        }

        public void Deposit()
        {
            Console.WriteLine("Enter amount");
            decimal amt=decimal.Parse(Console.ReadLine());
            balance += amt;
            Console.WriteLine(balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount");
            decimal amount=decimal.Parse(Console.ReadLine());
            if (balance - amount < 0)
                Console.WriteLine("Insufficient amount");
            else
               this.balance -= amount;
            Console.WriteLine("Balace amount {0}",balance);
        }
    }
}