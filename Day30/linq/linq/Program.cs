using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringList = new List<string>() {
                 "C# Tutorials",
                 "VB.NET Tutorials",
                 "Learn C++",
                 "MVC Tutorials" ,
                 "Java"
            };

            var result = stringList.Where(s => s.Contains("Tutorials"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");

            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
};

            // LINQ Method Syntax to find out teenager students
            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                              .ToList<Student>();


            foreach (var item1 in teenAgerStudents)
            {
                Console.WriteLine(item1.StudentName);
            }

            Console.WriteLine("-------------------------");
            var filteredResult = studentList.Where((s, i) =>
            {
                if (i % 2 == 0) // if it is even element
                    return true;

                return false;
            });

            foreach (var std in filteredResult)
                Console.WriteLine(std.StudentName);

            Console.WriteLine("----------------------");

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;

            foreach (var s in stringResult)
            {
                Console.WriteLine(s);
            }

            foreach (var s in intResult)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("------------");




            IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

            var innerJoin = from s in studentList // outer sequence
                            join st in standardList //inner sequence 
                            on s.StandardID equals st.StandardID // key selector 
                            select new
                            { // result selector 
                                StudentName = s.StudentName,
                                StandardName = st.StandardName
                            };

            foreach (var inner in innerJoin)
            {
                Console.WriteLine(inner.StandardName+"-"+inner.StudentName);
            }
        }
    }
}


