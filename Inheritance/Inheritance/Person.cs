using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Dob { get; set; }

        public Person() { 
            
        }
        public Person(string name, string id, string dob) {
            Name = name;
            Id = id;
            Dob = dob;

        }
        public void ShowInfo() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Dob: " + Dob);

        }
    }
}
