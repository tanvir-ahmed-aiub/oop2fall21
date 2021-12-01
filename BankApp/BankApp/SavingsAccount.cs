using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingsAccount : Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string no, string name, double balance) : base(no, name, balance) { }
        public override void Withdraw(double amount) {
            if (Balance - amount >= 500)
            {
                Balance -= amount;
            }
            else Console.WriteLine("Minimum Balance 500 not maintained");
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Type: Savings");
        }
    }
}
