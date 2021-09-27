using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //int a;
            //Console.WriteLine(a);
            //s1.name = "Tanvir";
            //s1.id = "123434";
            //s1.dob = "12.123.2";
            //s1.cgpa = (float)3.24;
            //s1.cgpa = 3.45f;
            s1.Name = "Tanvir Ahmed";
            Console.WriteLine(s1.Name);
            s1.ShowInfo();
        }
    }
}
