using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Add(int a, int b) {
            Console.WriteLine("The Sum is " + (a + b));
        }
        static void Add(double a, double b) {
            Console.WriteLine("The Sum is " + (a + b));
        }
        static void Add(string a, string b)
        {
            Console.WriteLine("The Sum is " + (a + b));
        }

        static void Main(string[] args)
        {
            /*Add(12, 23);
            Add(12.23, 12.34);
            Add("Tanvir ", "Ahmed");*/

            /*SavingsAccount sa = new SavingsAccount("Tanvir Ahmed", "123", 50000);
            Account a = new Account("Tanvir Ahmed", "123", 50000);

            sa.Withdraw(49700);
            sa.ShowInfo();*/
            //Polymorphic Behaviour of object
            Account sa2 = new SavingsAccount("Sabbir", "124",54000);
            sa2.Withdraw(53700);
            sa2.ShowInfo();
            


        }
    }
}
