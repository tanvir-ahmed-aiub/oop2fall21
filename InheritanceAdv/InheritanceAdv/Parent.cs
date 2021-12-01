using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAdv
{
    class Parent:GrandParent
    {
        public double Cgpa { get; set; }
        public int CourseCount { get; set; }
        public Parent() {
            Console.WriteLine("Parent default cons. called");
        }
        public Parent(double cgpa) : base(12,"") {
            Console.WriteLine("Parent cons. 1 para called");
        }
        public Parent(double cgpa, int ccnt) {
            Console.WriteLine("Parent cons. 2 para called");
        }

    }
}
