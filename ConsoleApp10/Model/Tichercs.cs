using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Model
{
    public class Tichercs : Piople
    {
        public Predmet [] Predmets { get; set; }

        public Tichercs(string name, DateTime dateBythDay) : base(name, dateBythDay) { }
        
    }

    public class Predmet
    {
        public  string Name { get; set; }
    }
}
