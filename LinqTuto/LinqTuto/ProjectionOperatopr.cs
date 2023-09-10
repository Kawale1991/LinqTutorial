using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
                Console.WriteLine($"Id = {e.Id},  Name = {e.Name}, Email = {e.Email} ");
            }

            // select only id using query
            var basict = (from e in employees
                          select e.Id).ToList();

            foreach (var eh in basict)
            {
                Console.WriteLine("selecting only id using qury " + eh);
            }


            // select only id using method
            var test = employees.Select(e => e.Id).ToList();

            foreach (var e in test)
            {
                Console.WriteLine("selecting only id using method " + e);
            }

            // select 2 fields using query
            var twof = (from t in employees
                        select new Employee()
                        {
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

            // select many Projection Operator using method

            List<string> customer = new List<string>() { "Shyam", "Bharati" };

            var customerresult = customer.SelectMany(x => x).ToList();

            foreach (var item in customerresult)
            {
                Console.WriteLine("Using select many projection method " + item);
            }


            // select many Projection Operator using query

            var customerresultquery = (from cus in customer
                                       from cu in cus
                                       select cu).ToList();


            foreach (var item in customerresultquery)
            {
                Console.WriteLine("Using select many projection query " + item);
            }

            // One more example using Projection selectmany() method

            var datasourc = new List<Employee>() {
            new Employee() { Id = 1, Name = "Shyam",Email="abc@gmail.com", Books = new List<string>(){ "English","Marathi","Hindi" }},
            new Employee() { Id = 2, Name = "Rohan",Email="jhk@gmail.com", Books = new List<string>(){ "English","Marathi","Hindi" }},
            new Employee() { Id = 3, Name = "Kalpna",Email="dfd@gmail.com", Books = new List<string>(){ "English","Marathi","Hindi" }},
            new Employee() { Id = 4, Name = "Bharati",Email="fdd@gmail.com", Books = new List<string>(){ "English","Marathi","Hindi" }}
            };

            var result = datasourc.SelectMany(x => x.Books).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("One more example using Projection selectmany() method " + item);
            }

            // One more example using Projection selectmany() query

            var result1 = (from emp in datasourc
                           from books in emp.Books
                           select books).ToList();

            foreach (var item in result1)
            {
                Console.WriteLine("One more example using Projection selectmany() query " + item);
            }

            // One more example using Projection selectmany() query multiple classes

            var dataselectmany = new List<Department>() {
            new Department(){ id=1,Name="shyam",Email="abc@gmail.com",Prgramming =
            new List<Techs> {
                new Techs() { Teachologies = "MVC" },
                new Techs() { Teachologies="c#" },
                new Techs() { Teachologies="net" }
            }},
            new Department(){ id=2,Name="Kiran", Email="test@gmail.com", Prgramming = 
            new List<Techs> {
                new Techs() { Teachologies = "OOps" },
                new Techs() { Teachologies = "Java" }
            }},
            new Department(){ id=3,Name="Suhana",Email="kbc@gmail.com", Prgramming= new List<Techs> ()},
            new Department(){ id=4,Name="Ramesh",Email="ramesh@gmail.com", Prgramming= new List<Techs> ()},
            };


            var techresultMethod = dataselectmany.SelectMany(x=> x.Prgramming).ToList();

            foreach(var tech in techresultMethod) { 
                Console.WriteLine("Multiple classes using method " + tech);
            }

            var techresultQuery = (from tech in dataselectmany
                                  from pro in tech.Prgramming
                                  select pro).ToList();

            foreach (var tech in techresultQuery)
            {
                Console.WriteLine("Multiple classes using query " + tech);
            }

            Console.ReadLine();

        }

    }
}
