using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SavingsAccount : Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string name, string no,double balance) :base(name,no,balance)
        { }
        public override void Withdraw(double amount) {
            if (Balance - amount >= 500) {
                Balance -= amount;
            }
            Console.WriteLine("Min balance 500");
        }
        public  void ShowInfo()
        {
            Console.WriteLine("Show info from Savingsaccount");
        }

    }
}
