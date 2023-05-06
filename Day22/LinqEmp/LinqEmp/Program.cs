using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEmp
{
    public class Employee
    {
        private string _name;

        public  string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public Employee() { }

        public Employee(string name, string city)
        {
            _name = name;   
            _city = city;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
           List<Employee> list = new List<Employee>();
            list.Add(new Employee("Anu", "del"));
            list.Add(new Employee("Megha", "Mumbai"));
            list.Add(new Employee("Don", "kerala"));
            list.Add(new Employee("Divya","Mumbai"));
            list.Add(new Employee("Alan","kerala"));

            var equery = from Employee emp in list
                         orderby emp.City
                         group emp by emp.City;

            foreach(var e in equery)
            {
                Console.WriteLine("Employee with " +e.Key+" City : ");
                foreach (var em in e)
                {
                    Console.WriteLine(" "+em.Name);
                }
            }
        }
    }
}
