using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTuto
{
    // == , >=, <=, &&, > , < , ||, Etc.
    public class FilteringOperators
    {

        public static void Main(string[] args)
        {
            //Where operator using > operator****************************************************

            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = (from n in dataSource
                          where n > 5
                          select n).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("The value is greather is using query " + item);
            }

            var result1 = dataSource.Where(x => x > 5).ToList();

            foreach (var item in result1)
            {
                Console.WriteLine("The value is greather is using method " + item);
            }

            //Where operator using < operator****************************************************

            var result2 = (from n in dataSource
                           where n < 5
                           select n).ToList();

            foreach (var item in result2)
            {
                Console.WriteLine("The value is less than is using query " + item);
            }

            var result3 = dataSource.Where(x => x < 5).ToList();

            foreach (var item in result3)
            {
                Console.WriteLine("The value is less than is using method " + item);
            }

            //Where operator using <= operator*****************************************************

            var result4 = (from n in dataSource
                           where n <= 5
                           select n).ToList();

            foreach (var item in result4)
            {
                Console.WriteLine("The value is less than eqal to is using query " + item);
            }

            var result5 = dataSource.Where(x => x <= 5).ToList();

            foreach (var item in result5)
            {
                Console.WriteLine("The value is less than equal to is using method " + item);
            }

            //Where operator using == operator*****************************************************

            var result6 = (from n in dataSource
                           where n == 5
                           select n).ToList();

            foreach (var item in result6)
            {
                Console.WriteLine("The value is double than equal to is using query " + item);
            }

            var result7 = dataSource.Where(x => x == 5).ToList();

            foreach (var item in result7)
            {
                Console.WriteLine("The value is double than equal to is using method " + item);
            }

            //Where operator using || operator*****************************************************

            var result8 = (from n in dataSource
                           where n == 5 || n > 8
                           select n).ToList();

            foreach (var item in result8)
            {
                Console.WriteLine("The value is double than equal to is using query " + item);
            }

            var result9 = dataSource.Where(x => x == 5 || x > 8 ).ToList();

            foreach (var item in result9)
            {
                Console.WriteLine("The value is double than equal to is using method " + item);
            }

            //Where operator using string datatype == operator*****************************************************

            var stringData = new List<string>() { "shyam","raj","arun"};

            var data = (from n in stringData
                           where n.Length == 5 
                           select n).ToList();

            foreach (var item in data)
            {
                Console.WriteLine("The value is double than equal to is using query " + item);
            }

            var data1 = stringData.Where(x => x.Length == 5).ToList();

            foreach (var item in data1)
            {
                Console.WriteLine("The value is double than equal to is using method " + item);
            }


            Console.ReadLine();
        
        }

        
    }
}
