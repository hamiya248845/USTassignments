using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new BankTBEntities())
            //{
            //    var std = new BankTB()
            //    {
            //        ACCNO = 106,
            //        Accountholdername = "Alan",
            //        BALANCE = 1000,
            //        RefAccno = 102
            //    };
            //    context.BankTBs.Add(std);

            //    context.SaveChanges();
            //}

            using (var context = new BankTBEntities())
            {
                //var std = context.BankTBs.First<BankTB>();
                //std.BALANCE = 15000;
                //context.SaveChanges();

                var std = context.BankTBs.First<BankTB>();
                context.BankTBs.Remove(std);

                context.SaveChanges();
            }


        }
    }
}
