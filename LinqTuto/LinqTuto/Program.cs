using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is another query result");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from n in numbers
                         where n > 2
                         select n;
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("This is another method result");

            var result1 = numbers.Where(n => n > 2).ToList();
            foreach (var item in result1)
            {
                Console.WriteLine($"{item}");
            }


            Console.WriteLine("Find max number in list using query");

            var maxnumber = (from k in numbers
                             select k).Max();

            Console.WriteLine(maxnumber);


            Console.WriteLine("Find max number in list using method");

            var maxnumber1 = numbers.Max();

            Console.WriteLine(maxnumber1);

            Console.WriteLine("Using Employee class properties using query");

            List<Employee> employees = new List<Employee>() {
                new Employee() {id=1,Name="shyam" },
                new Employee() {id=2,Name="Bharati"}
            };

            IEnumerable<Employee> employe = from emp in employees 
                                            select emp;

            foreach (var item in employe)
            {
                Console.WriteLine(item.id + "" + item.Name);
            }

            Console.WriteLine("Using Employee class properties using method");
            IEnumerable<Employee> employees1 = employees.ToList();

            foreach (var item in employees1)
            {
                Console.Write(item.id + ""+ item.Name);
            }
            

           

            Console.ReadLine();
        }

        class Employee
        {
            public int id { get; set; }
            public string Name { get; set; }
        }
    }
}
