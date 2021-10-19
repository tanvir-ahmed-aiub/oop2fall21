using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class SavingsAccount : BankAccount
    {
        public void Withdraw(int amount) {
            if (Balance - amount >= 500)
            {
                Balance -= amount;
            }
            else 
            {
                Console.WriteLine("Insufficient Balance");
                //not suff.
            }
            
            
        }
    }
}
