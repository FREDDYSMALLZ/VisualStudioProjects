using System;

namespace SalesTax
{
   public class SalesTax
    {
      public  static void Main(string[] args)
        {
           
            double taxA = 0.04;
            double taxB = 0.055;

            Console.Write("Enter a purchase price in country A, -1 to quit ");
            double priceA = double.Parse(Console.ReadLine());

            Console.Write("Enter a purchase price in country B, -1 to quit ");
            double priceB = double.Parse(Console.ReadLine());

            double SalesTaxA = taxA * priceA;
            double SalesTaxB = taxB * priceB;

            double TotalSaleA = priceA + SalesTaxA;
            double TotalSaleB = priceB + SalesTaxB;
            double totalSales = TotalSaleA + TotalSaleB;
          
            Console.Write("The total sales tax is {0}", totalSales);

            Console.ReadLine();
        }
    }
}