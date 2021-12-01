using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Person
    {
        public string Name { get; set; }
        Account[] accounts;
        int count;
        public Person()
        {
            accounts = new Account[100];
        }
        public void AddAccount(Account a) {
            accounts[count++] = a;
        }
        public void ShowAccount() {
            for (int i = 0; i < count; i++) {
                accounts[i].Show();
            }
        }
    }
}
