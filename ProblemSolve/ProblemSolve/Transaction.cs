using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolve
{
    class Transaction
    {
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public string Purpose { get; set; }
        public double Amount { set; get; }
        public Transaction(Account sender,Account receiver, string purpose, double amount) {
            Sender = sender;
            Receiver = receiver;
            Purpose = purpose;
            Amount = amount;
        }

        public void Details() {
            Console.WriteLine("Sender: {0}({1})", Sender.AccName, Sender.AccNo);
            //Console.WriteLine("Sender: " +Sender.AccName+"("+Sender.AccNo+")");
            Console.WriteLine("Receiver: {0}({1})", Receiver.AccName, Receiver.AccNo);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Amount: " + Amount);

        }
        
    }
}
