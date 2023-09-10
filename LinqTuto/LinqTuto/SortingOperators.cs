using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LinqTuto
{
    public class SortingOperators
    {
        // Sorting Operators has five operators 
        // 1 => OrderBy
        // 2 => OrderByDescending
        // 3 => ThenBy
        // 4 => ThenByDescending
        // 5 => Reverse
        public static void Main(string[] args)
        { 
            //Order by operator

            var result = new List<int>() { 1,5,7,9,6};
            var result1 = result.OrderBy(x => x).ToList();

            foreach (var x in result1) { 
                Console.WriteLine("Method Using orderby operator the value is " + x);
            }

            var result2 = (from n in result
                          orderby n
                          select n).ToList();


            foreach (var x in result2) {
                Console.WriteLine("Query Using orderby operator the value is " + x);
            }

            //OrderByDescending

            var result3 = result.OrderByDescending(x => x).ToList();

            foreach (var x in result3)
            {
                Console.WriteLine("Method Using orderbydescending operator the value is " + x);
            }

            var result4 = (from n in result
                           orderby n descending
                           select n).ToList();


            foreach (var x in result4)
            {
                Console.WriteLine("Query Using orderbydescending operator the value is " + x);
            }


            //Reverse Operators for int***************************************************************

            int[] da = new int[] { 1,2,3,4,5,6,7};

            var das = da.Reverse().ToList();

            foreach(var x in das)
            {
                Console.WriteLine("the reverse " + x);
            }

            var das1 = (from d in da
                        select d).Reverse();

            foreach (var x in das1)
            {
                Console.WriteLine("the reverse " + x);
            }

            //Reverse Operators for string***************************************************************

            List<string> list = new List<string>() { "shyam","bharati"};

            // 2 ways are there
            var list2 = list.AsEnumerable().Reverse();
            //list.Reverse();

            foreach(var x in list2)
            {
                Console.WriteLine("the value of string using reverse operator method is " + x);
            }


            Console.ReadLine();
        
        }
    }
}
