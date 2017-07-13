using System;

/*Write a program that reads three integers from
 * the keyboad and outputs
 * their sum and product
*/

namespace IntegerOutput
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Console.Write("Enter the first integer number: ");
            int number_1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer number: ");
            int number_2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third integer number: ");
            int number_3 = int.Parse(Console.ReadLine());

            int sum = number_1 + number_2 + number_3;
            int product = number_1 * number_2 * number_3;

            Console.WriteLine("{0} is the sum of {1}, {2} and {3}",
                sum , number_1, number_2, number_3);
            Console.WriteLine("{0} is the product of {1}, {2} and {3}",
                product, number_1, number_2, number_3);

        }
    }
}