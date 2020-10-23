using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class SavingsAccount : BankAccount
    {
        private float intrestRate;
        public string acctAge;
        public override void accountAge()
        {
            acctAge = "30 Years";
        }
        public SavingsAccount(long bal, int acct) : base(bal, acct)
        {
            intrestRate = 5;
        }
        public float IntrestRate
        {
            get { return intrestRate; }
        }
    }
}
