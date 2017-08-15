using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Exercise_24
{
   public class Company_Stores
    {
       public static void Main(string[] args)
        {
            double [,] Company_Weekly_Sales = { { 200.23, 1 }, { 221.45, 1 }, { 109.98, 1}, { 201.46, 1}, { 789.92, 1} };
            
            double Range;

            for (double i = 0; i < Company_Weekly_Sales.GetLength(0); i++)
            {
                Range = 0;
            }
            for (double j = 0; j < Company_Weekly_Sales.GetLength(1); j++)
            {
                Range += [i, j];
            }
            Console.WriteLine("The average sales for the company is ", i);
         





            Console.ReadLine();
        }

       
    }
}
