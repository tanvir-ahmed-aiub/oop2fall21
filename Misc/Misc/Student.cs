using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Student
    {
        readonly int test;
        const int constant = 2;
        public int Id { get; set; }
        public int Name { get; set; }
        public static int Count { get; set; }
        public int Credit { get; set; }
        public Student() {
            test = 12;
            Count++;
            
        }
        public void TestFunc() {
            //test = 32;
        }
    }
}
