using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LinqTuto
{
    public class OffTypeOperators
    {
        public static void Main(string[] args)
        {
            var result = new List<object>() { "abc","kcb","rcd",1,2,3,4};

            var result1 =result.OfType<int>().ToList();
            
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            var result2 = (from res in result
                           where res is string
                           select res).ToList();

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        
        }
    }
}
