/*The program find the maximum of prices that the user enters.
 * The user enters a negative value to indicate that no more
 * data is available.
 * Then the program displays the maximum value
*/

using System;

namespace Example_3._7
{
    public class Max
    {
        public static double UpdateMax
            (double newPrice, double maxSoFar)
        {
            if (newPrice > maxSoFar)
                return newPrice;
            else
                return maxSoFar;

        }
        public static double Get_Double(String prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }
       public static void Main()
        {
            double maxSoFar = 0;
            double price = Get_Double("Enter the first price, -1 to quit: ");

            while (price > 0)
            {
                maxSoFar = UpdateMax(price, maxSoFar);
                price = Get_Double("Enter the next price, -1 to quit: ");
            }

            Console.WriteLine("The maximum is {0}", maxSoFar);

            Console.ReadLine();
        }
        
           
        }
    }
