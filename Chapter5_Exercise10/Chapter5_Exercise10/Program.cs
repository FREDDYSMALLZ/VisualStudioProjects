using System;

namespace Chapter5_Exercise10
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }
        public BankAccount(double initialAmout)
        {
            balance = initialAmout;
        }
        public double getBalance()
        {
            return balance;
        }
        
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (balance >= amount)
                balance -= amount;
            else
                throw new Exception("Insufficient funds");
        }
        public void Withdraw(int amount)
        {
            if (balance >= amount)
                balance -= amount;
            else
                throw new Exception("Insufficient funds");

        }

        /*
        public override string ToString()
        {
            return (String.Format("({0:C}, {1:C}, {2:C} ", balance, Deposit, Withdraw));
        }
        */

        public static void Main(string[] args)
        {
            BankAccount myBankAccount = new BankAccount(7000.98);
            myBankAccount.Deposit(450.45);
            myBankAccount.Withdraw(40.00);
            Console.WriteLine("My Bank account has a balance of {0:C}",myBankAccount.balance);

            /*Console.WriteLine("My Bank account has a balance of {0:C} after Depositing {1:C}" +
               "and Withdrwaing {2:C}", myBankAccount.balance
               ,myBankAccount.Deposit, myBankAccount.Withdraw);

           */
            Console.ReadLine();
           
        }
    }
}