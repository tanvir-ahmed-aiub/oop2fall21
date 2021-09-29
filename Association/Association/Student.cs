using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Auto implemented property
        public string Id { get; }
        // now the ID can only be set in constructor
        //public string Id { get;  private set;}
        //can set inside class
        public string Dob;
        public Department Department { get; set; }

        public Student() {
            
        }
        public Student(string name, string id, string dob) {
            this.name = name;
            this.Id = id;
            this.Dob = dob;
        }
        public void ShowInfo() {
            Console.WriteLine("Id: " +Id);
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Dob: " +Dob);


        }
       

    }
}
