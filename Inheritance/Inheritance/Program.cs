
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Cgpa = 3.96f;
            s.Department = "CS";
            s.Name = "Tanvir Ahmed";
            s.Id = "2323";
            s.Dob = "33.12.12";
            s.ShowInfo();

            Teacher t = new Teacher();
            t.Dob = "";
            t.Id = "";
            t.Name = "";

            CurrentAcount sa = new CurrentAcount();
            sa.AccName = "tanvir";
            sa.AccNo = "1233";
            sa.Balance = 5000;
            sa.Withdraw(4500);
            sa.Withdraw(1);
                
        }
    }
}
