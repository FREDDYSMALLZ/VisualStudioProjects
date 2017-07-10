using System;
/* The program computes the 
 * rental cost of a car
*/

namespace RentalCost
{
    public class RentalCost
    {
        /* Cost is $30 per day for the first three days
         * and $20 for each additional day.
         * 
         * input: number of days
         * output: cost of rental
        */
        public static int Cost(int days)
        {
            int pay;
            if (days <= 3)
            {
                pay = days * 30;
            }
            else
            {
                pay = 90 + 20 * (days - 3);
            }
            return pay;

        }
        // Promt the user to enter the rental days
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of rental days: ");
            int days = int.Parse(Console.ReadLine( ));

            Console.WriteLine("The rental cost is {0:C}", Cost(days));
        }
    }
}
