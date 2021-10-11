using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            Account tanvir = new Account("123456","Tanvir Ahmed",50000);
            Account sabbir = new Account("123457","Sabbir Ahmed",500000);

            tanvir.Deposit(23000);
            sabbir.Withdraw(50000);
            tanvir.Details();
            Console.WriteLine("----------------------");
            sabbir.Details();
            Console.WriteLine("--------Transfer------");
            sabbir.Transfer(tanvir, 100000, "Medical Purpose");
            tanvir.Details();
            sabbir.Details();
            Console.WriteLine("--------Debt----------");
            tanvir.Transfer(sabbir, 100000, "Debt Payment");
            tanvir.Details();
            sabbir.Details();
            Console.WriteLine("------Transaction-----");
            sabbir.Withdraw(200000);
            sabbir.Withdraw(500000);
            sabbir.ShowTransactions();

        }
    }
}
