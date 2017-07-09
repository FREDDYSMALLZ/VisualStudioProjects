using System;
/*Adds a WriteLine statement in
 * the body of the while loop
*/ 
namespace Mistake1Debugging
{
   public class Mistake1Debugging
    {
        //Uses a while loop to compute the sum of squares
      public  static void Main() // Step Over debugging executes the method 
                                 //call without executing each line of the method
        {                        //Step over starts here on this line.
            int sum = 0;
            int count = 1;   //Current value to add and square

            Console.Write("Enter the number of squares to sum:");
            int high = int.Parse(Console.ReadLine());
            while (count <= high)
            {
                sum += count * count;
                count++;
            }// means that after square of count, the sum is added

            Console.WriteLine("The sum of the first {0} squares is {1}", high, sum);
        }
    }
}