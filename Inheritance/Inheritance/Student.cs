
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student:Person
    {
        public float Cgpa { get; set; }
        public string Department { get; set; }

        public void Show() {
            Console.WriteLine("name"+Name);
        }

    }
}
