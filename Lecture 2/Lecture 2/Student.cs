using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2
{
    class Student
    {
        //fields
        private string name;
        public string dob;
        public string id;
        public float cgpa;

        //properties or accessors similar to getter and setter
        public string Name {
            get { return name; }
            set { name = value; }
        }


        //constructor
        public Student() {
            name = "default";
            dob = "12,12.2";
           
        }
        
        //methods
        public void ShowInfo() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Cgpa: {0}", cgpa);
        }

    }
}
