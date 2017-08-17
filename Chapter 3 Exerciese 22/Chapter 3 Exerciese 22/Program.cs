using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Exerciese_22
{
    public  class SimpleInterest
    {
        public static void Main(string[] args)
        {

            Console.Write("Please Enter the Initial account balance: ");
            String input = Console.ReadLine();
            double Balance = double.Parse(input);

            Console.Write("Please Enter the inerest rate: ");
            String input1 = Console.ReadLine();
            double interest_Rate = double.Parse(input1);

            Console.Write("Please Enter the Final account balance: ");
            String input2 = Console.ReadLine();
            double Final_Balance = double.Parse(input2);

            double Number_Of_Years = ((1 / (interest_Rate / 100)) * 
                ((Final_Balance / Balance) - 1)) / 12;


            Console.WriteLine("The final balance at in the account will be {0:C}, after " +
                "{1:F2} years", Final_Balance, Number_Of_Years);


            Console.ReadLine();
        }      
    }
}
