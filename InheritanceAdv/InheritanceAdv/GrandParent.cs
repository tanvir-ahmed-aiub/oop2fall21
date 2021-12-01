using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAdv
{
    class GrandParent:GreatGrandParent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GrandParent():base(12) {
            Console.WriteLine("Grand default cons. called");
        }
        public GrandParent(int id) :base(id)
        {
            Console.WriteLine("Grand cons. para 1 called");
        }
        public GrandParent(int id, string name) {
            Console.WriteLine("Grand cons. para 2 called");
        }
    }
}
