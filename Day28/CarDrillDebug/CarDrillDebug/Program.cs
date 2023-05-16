using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDrillDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine("Enter the product name");
            p._productName = Console.ReadLine();
            Console.WriteLine("Enter the supplier name");
            p._supplierName = Console.ReadLine();
            Console.WriteLine("Enter the product id");
            p._id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Product Id is " + p._id);
            Console.WriteLine("Product Name is " + p._productName);
            Console.WriteLine("Supplier Name is " + p._supplierName);
        }
    }
}
