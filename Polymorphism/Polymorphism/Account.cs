using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string name, string no,double balance) {
            AccName = name;
            AccNo = no;
            Balance = balance;
        }
        public void Deposit(double amount) {
            Balance += amount;
        }
        public virtual void Withdraw(double amount) {
            if (amount < Balance) Balance -= amount;
            else Console.WriteLine("Insufficient balance");
        }
        public virtual void ShowInfo() {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
