using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Declares a Bank Account class with an amount balance,
 * two constructors, GetBalance, Deposit and
 * Withdrwa operations
*/

namespace Example_5._1
{
   public class BankAccount
    {
        private double balance;
        public BankAccount()
        {
            double balance = 0; // Creates a bank account with a balance of zero
        }
        public BankAccount(double initialAmount)//Creates a Bank account with a balance of initial amount
        {
           balance = initialAmount;
        }
    
        public double GetBalance()// Returns the balance
        {
            return balance;
        }
        public void Deposit (double amount) //Increases the balance by the deposited amount
        {
            balance += amount;
        }
        public void Withdraw (double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return ;
            }
            else
            {
                return ;
            }
             
        }
       public static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(25.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());
            myAccount.Deposit(700.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());


            myAccount.Withdraw(40.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            Console.ReadLine();


        }
    }
}
