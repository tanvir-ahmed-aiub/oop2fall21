using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAdv
{
    class Child:Parent
    {
        public double Salary { get; set; }
        public double Savings { get; set; }
        public Child() : base(12.00){
            Console.WriteLine("Child cons. default called");
        
        }
        public Child(double s, double v) : base()
        {
            Console.WriteLine("Child cons. 2 called");


        }
    }
}
