using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class TermDepositAccount : Account
    {
        int tenureyear;
        DateTime creationTime;
        public TermDepositAccount() { }
        public TermDepositAccount(string no, string name, double balance,int tenureyear, DateTime ct)
            : base(no, name, balance) 
        {
            this.tenureyear = tenureyear;
            creationTime = ct;
        }
        public override void Withdraw(double amount)
        {
            DateTime now = DateTime.Now;
            int c_year = now.Year; //current year
            int acop_year = creationTime.Year; //acc opn year
            if (c_year - acop_year >= tenureyear)
            {
                Balance -= amount;
            }
            else {
                Console.WriteLine("Your acc is not matured yet");
            }
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Type: Term of {0} years",tenureyear);
            Console.WriteLine("Creation year: " + creationTime.Year);
            Console.WriteLine("Tenure year: " + tenureyear);
        }
    }
}
