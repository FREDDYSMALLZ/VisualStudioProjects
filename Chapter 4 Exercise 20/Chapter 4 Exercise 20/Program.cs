using System;

namespace Chapter_4_Exercise_20
{
    public class ConvertCurrency
    {
        public static void AmericanDollarsToPounds()
        {
            Console.WriteLine("Converting from American Dollars to British Pounds.");
        }
        public static void BritishPoundsToDollars()
        {
            Console.WriteLine("Converting from British Pounds to American Dollars.");
        }
        public static void Main(string[] args)
        {
        
            int choice;
            double amount;
            double pounds = 1.6595;
            double AmericanDollarsToPounds;
            double BritishPoundsToDollars;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please choose from the following list");
                Console.WriteLine("1. Convert from British Pounds to American Dollars");
                Console.WriteLine("2. Convert from American Dollars to British Pounds");
                Console.WriteLine("3. Quit the System");

                Console.Write("Please enter your choice: 1, 2, or 3");
                Console.Write("Please enter the amount to convert");
                String input = Console.ReadLine();
                choice = int.Parse(input);
                amount = double.Parse(input);

                switch (choice)
                {
                    case 1:
                        AmericanDollarsToPounds = amount / pounds;
                        break;
                    case 2:
                        BritishPoundsToDollars = amount * pounds;
                        break;
                    case 3:
                        Console.WriteLine("Bye, have a great day");
                        break;
                }

            } while (choice != 3);

            Console.WriteLine("When converted, {0} converts to {1:C}", amount ); 
            Console.ReadLine();
        }
    }
}