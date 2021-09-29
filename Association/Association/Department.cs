using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Student[] students;
        int sCount; // to trace no of students inserted
        public Department() {
            students = new Student[500];
        }
        public Department(int id, string name) {
            Id = id;
            Name = name;
            students = new Student[500];
        }
        public void AddStudent(Student s) {
            if (sCount < 500)
            {
                students[sCount++] = s;
                
            }
            else {
                Console.WriteLine("MAX LIMIT EXCEEDS");
            }
        }
        public void ShowStudents() {
            Console.WriteLine("Dept. Name: " + Name);
            for (int i = 0; i < sCount; i++) {
                students[i].ShowInfo();
            }
        }


    }
}
