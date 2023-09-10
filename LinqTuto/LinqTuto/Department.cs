using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTuto
{
    public class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Techs> Prgramming { get; set; }

    }
    public class Techs
    {
        public string Teachologies { get; set; }
    }
}
