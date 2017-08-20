using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Exercise_24
{

    public class AnnualInflation
    {

        public static void Main(string[] args)
        {

            Console.Write("Please Enter the Annual Inflation Rate. ");
            String input = Console.ReadLine();
            double Annual_Inflation_Rate = double.Parse(input);

            Console.Write("Please Enter the cost of the item now. ");
            String input1 = Console.ReadLine();
            double Cost_Of_Item_Now = double.Parse(input1);// Cost of item at the start of inflation

            Console.Write("Please Enter the number of years the Inflation took. ");
            String input2 = Console.ReadLine();
            double Number_Of_Years = double.Parse(input2);


            double Cost_Of_Item_After = ((Cost_Of_Item_Now * Annual_Inflation_Rate) // Calculates the Cost of the item after inflation period
                    + (Cost_Of_Item_Now * 100)) / 100;


            Console.WriteLine("The cost of item is {0:C}, after {1} year(s). ", Cost_Of_Item_After, Number_Of_Years);

            Console.ReadLine();
        }
    }
}

