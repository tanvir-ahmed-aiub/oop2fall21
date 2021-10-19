using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CurrentAcount:BankAccount
    {
        public void Withdraw(int amount) {
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient Balance");
        }
    }
}
