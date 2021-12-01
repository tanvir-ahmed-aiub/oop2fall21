using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAdv
{
    class GreatGrandParent
    {
        public string Car { get; set; }
        public void CarRun() { }
        public GreatGrandParent() {
            Console.WriteLine("Greatgrand default cons. called");
        }
        public GreatGrandParent(int id) {
            Console.WriteLine("Greatgrand  cons. para 1 called");
        }
    }
}
