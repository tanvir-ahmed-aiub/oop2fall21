using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BankAccount
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public int Balance { get; set; }
        public BankAccount() {
            
        }
        public void Deposit(int amount) {
            Balance += amount;
        }
        public void ShowInfo() {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }

       
    }
}
