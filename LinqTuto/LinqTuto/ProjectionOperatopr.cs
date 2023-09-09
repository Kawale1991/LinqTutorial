using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTuto
{
    class ProjectionOperatopr
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee() { Id = 1, Name="Shyam",Email="shyamkawale30@gmail.com"},
                new Employee() { Id = 2,Name="Ravi",Email ="Ravi@gmail.com"},
                new Employee() { Id = 3,Name="Surya",Email="Surya@gmail.com"}
            };

            //select all using query
            var basic = (from e in employees
                        select e).ToList();

            foreach (var e in basic)
            {
                Console.WriteLine($"Id = { e.Id },  Name = { e.Name }, Email = { e.Email } ");
            }

            // select only id using query
            var basict = (from e in employees
                         select e.Id).ToList();

            foreach (var eh in basict)
            { 
            Console.WriteLine("selecting only id using qury "+ eh);
            }


            // select only id using method
            var test = employees.Select(e => e.Id).ToList();

            foreach (var e in test)
            { 
            Console.WriteLine("selecting only id using method " + e);
            }

            // select 2 fields using query
            var twof = (from t in employees
                        select new Employee() { 
                            Id = t.Id,
                            Name = t.Name
                        }).ToList();

            foreach (var e in twof)
            {
                Console.WriteLine("display 2 properties using query = ID is " + e.Id + " Name is " + e.Name);
            }

            // merge properties to another class using query

            var EmployeeMerge = (from e in employees
                                select new Student()
                                { 
                                    SId = e.Id,
                                    SName = e.Name,
                                    SEmail = e.Email
                                }).ToList();
            foreach (var e in EmployeeMerge)
            {
                Console.WriteLine("merge properties to another class using query = ID is " + e.SId + " Name is " + e.SName);
            }

            // merge properties to another class using method

            var EmployeeMergeMethod = employees.Select(emp => new Student()
                                      { SId = emp.Id, SEmail = emp.Email, SName = emp.Name }).ToList();
            foreach (var ed in EmployeeMergeMethod)
            {
                Console.WriteLine("merge properties to another class using method = ID is " + ed.SId + " Name is " + ed.SName);
            }


            // merge properties to annymeous using query

            var EmployeeAnnoymeous = (from e in employees
                                 select new 
                                 {
                                     CustomeSId = e.Id,
                                     CustomSName = e.Name,
                                     CustomeSEmail = e.Email
                                 }).ToList();
            foreach (var e in EmployeeAnnoymeous)
            {

                Console.WriteLine("merge properties to annymeous using query = ID is " + e.CustomeSId + " Name is " + e.CustomSName);
            }

            // merge properties to annymeous using method
            var EmployeeAnnoymeousMethod = employees.Select(emp => new 
            { cusSId = emp.Id, cusSEmail = emp.Email, cusSName = emp.Name }).ToList();
            foreach (var ed in EmployeeAnnoymeousMethod)
            {
                Console.WriteLine("merge properties to another class using method = ID is " + ed.cusSId + " Name is " + ed.cusSName);
            }

            Console.ReadLine();

        }

    }
}
