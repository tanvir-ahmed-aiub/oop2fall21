using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Person tan = new Person();

            Account acc = new CurrentAccount("1234", "Tanvir", 1000);
            Account acc2 = new SavingsAccount("12345", "Tanvir", 20000);
            DateTime accd = DateTime.Parse("2019-08-12");
            Account acc3 = new TermDepositAccount("123456", "Tanvir", 200000,5,accd);

            tan.AddAccount(acc);
            tan.AddAccount(acc2);
            tan.AddAccount(acc3);

            tan.ShowAccount();



        }
    }
}
