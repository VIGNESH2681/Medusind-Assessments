using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    
    public class Accounts
    {
         int accountNo;
         string customerName;
         string accountType;
         string transactionType;
         double amount;
         double balance;

        public Accounts(int accountno, string customerName, string accountType, string transactionType, double amount) 
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = 2000;
        }

        public void credit(double amount)
        {
            balance += amount;
        }

        public void debit(double amount)
        {
            balance -= amount;
        }

        public void ShowData() 
        {
            Console.WriteLine("enter accountNo:");
            this.accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer's name:");
            this.CusName = Console.ReadLine();
            Console.WriteLine("enter accountType:");
            this.accountType = Console.ReadLine();
            Console.WriteLine("enter transactionType (D->deposit / W->withdrawal):");
            this.transactionType = Console.ReadLine();
            Console.WriteLine("enter amount:");
            this.amount = Convert.ToDouble(Console.ReadLine());
            if (transactionType == "D")
            {
                transactionType = "Deposit";
                balance = balance + amount;
            }
            else if (transactionType == "W" && amount < balance)
            {
                transactionType = "Withdrawal";
                balance = balance - amount;
            }
            else if (transactionType == "W" && amount > balance)
            {
                transactionType = "Transaction is not possible.";
            }
            Console.WriteLine("accountNo:"+accountNo);
            Console.WriteLine("customerName:"+customerName);
            Console.WriteLine("accountType:" +accountType);
            Console.WriteLine("transactionType:" +transactionType);
            Console.WriteLine("amount:"+amount);
            Console.WriteLine("balance:"+balance);
        }
    }
    public class Accounts03
    {
        public static void Main(string[] args)
        {
            Accounts acc = new Accounts(6574339,"Vignesh G","savings","D",40000.00);
            acc.credit(2000);
            acc.debit(1000);
            acc.ShowData();
            Console.Read();
        }
    }

}