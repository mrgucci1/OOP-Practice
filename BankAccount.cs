using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public abstract class BankAccount
    {
        private long balance;
        private int accountNumber;
        public string bank = "Schwab";
        public abstract void accountAge();
        public BankAccount(long bal, int acct)
        {
            balance = bal;
            accountNumber = acct;
        }

        //Deposit
        public string deposit(int amount)
        {
            balance = balance + amount;
            return ($"Deposited: {amount} into your account");
        }
        public string withdraw(int amount)
        {
            if (amount > balance)
                return ("You cannont withdraw more than account value!");
            else
                balance = balance - amount;
            return ($"Withdrew: {amount} from your account");
        }
        //Get/Set fucntion for balance
        public long Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        //Get only function for account number
        public long AccountNumber
        {
            get { return accountNumber; }
        }
        
    }
}
