using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolve
{
    class Account
    {
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public double Balance { get; set; }
        Transaction[] transactions;
        int noOfT;
        public Account() {
            transactions = new Transaction[1000];
        }
        public Account(string accNo, string accName, double balance)
        {
            AccNo = accNo;
            AccName = accName;
            Balance = balance;
            transactions = new Transaction[1000];
            Transaction t = new Transaction(this, this, "Opening Account",balance);
            this.AddTransaction(t);
            
        }
        public void AddTransaction(Transaction t) {
            if (noOfT < 1000) {
                transactions[noOfT++] = t;
            }
        
        }
        public void ShowTransactions() {
            Console.WriteLine("-------All Transactions------");
            for (int i = 0; i < noOfT; i++) {
                transactions[i].Details();
            }
            Console.WriteLine("-------Transactions End------");
        }
        public void Deposit(double amount) {
            Balance += amount;
            Transaction t = new Transaction(this, this, "Self Deposit", amount);
            this.AddTransaction(t);
        }
        public void Withdraw(double amount) {
            if (amount < Balance)
            {
                Balance -= amount;
                Transaction t = new Transaction(this, this, "Self Withdraw", amount);
                this.AddTransaction(t);
            }
            else {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public void Transfer(Account receiver, double amount,string info) {
            if (this.Balance > amount) {
                this.Balance -= amount;
                receiver.Balance += amount;
                Transaction t = new Transaction(this, receiver, info,amount);
                this.AddTransaction(t);
                receiver.AddTransaction(t);
            }
        }
        public void Details() {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
