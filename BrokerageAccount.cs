using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class BrokerageAccount : BankAccount
    {
        private string[] companyStocks;
        private long stockValue;
        public string acctAge;
        public BrokerageAccount(long bal, int acct) : base(bal, acct)
        {
            companyStocks = new string[] { "Schwab", "Tesla", "Amazon" };
            stockValue = 800;
        }
        public override void accountAge()
        {
            acctAge = "10 Years";
        }
        //Function to sell stocks
        public string sellStock(string stock)
        {
            bool stockHeld = false;
            for (int i = 0; i < companyStocks.Length; i++)
            {
                if (stock == companyStocks[i].ToString())
                {
                    companyStocks[i] = "";
                    stockHeld = true;
                    stockValue = stockValue - 200;
                    Balance = Balance + 200;
                }
            }
            companyStocks = companyStocks.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            if (stockHeld)
                return ($"You successfuly sold: {stock} for $200");
            else
                return ("You do not hold that asset");

        }
        //Get Only for assest held in brokerage
        public string[] CompanyStocks
        {
            get { return companyStocks; }
        }
    }
}
