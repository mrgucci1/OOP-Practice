using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Brokerage and Savings Account
            BrokerageAccount account1 = new BrokerageAccount(1000, 123456);
            SavingsAccount account2 = new SavingsAccount(5000, 789123);
            //Print Current Acount values
            Console.WriteLine($"Brokerage accont at: {account1.bank} Account Number: {account1.AccountNumber}\nBalance = {account1.Balance}");
            Console.WriteLine($"Assests in your portfolio include");
            foreach (string asset in account1.CompanyStocks)
                Console.WriteLine(asset);
            Console.WriteLine($"\nSavings Account at: {account2.bank} Account Number: {account2.AccountNumber}\nBalance = {account2.Balance}");
            Console.WriteLine($"Intrest Rate: {account2.IntrestRate}");
            Console.WriteLine("Depositing $100 into brokerage");
            Console.WriteLine(account1.deposit(100));
            Console.WriteLine($"Brokerage Balance: {account1.Balance}");
            Console.WriteLine("Withdrawing $200 from savings");
            Console.WriteLine(account2.withdraw(200));
            Console.WriteLine($"Savings Balance: {account2.Balance}");
            Console.WriteLine("Selling Tesla from stocks");
            Console.WriteLine(account1.sellStock("Tesla"));
            Console.ReadKey();
        }
    }
}
