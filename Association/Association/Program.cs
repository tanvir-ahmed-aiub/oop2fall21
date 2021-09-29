using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir", "12", "sdsf");
            Student s2 = new Student("Sabbir", "13", "ssd");

            Department d1 = new Department(1,"CS");

            d1.AddStudent(s1);
            s1.Department = d1;
            d1.AddStudent(s2);
            s2.Department = d1;

            d1.ShowStudents();

            Console.WriteLine(s1.Department.Name);


        }
    }
}
