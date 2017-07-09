using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Incoreect attempt to sum up the squares of
 * numbers from 1 to a high value entered 
 * by the user
 * 
 */
namespace Mistake1
{
    public class Mistake1
    {
        //Use a loop to compute the sum of squares

        static void Main(string[] args)
        {
            int sum = 0;   //Current value of the square and add
            int count = 1;

            Console.WriteLine("Enter the number of squares to sum:");

            int high = int.Parse(Console.ReadLine());

            while (count <= high) //No curly braces present
                sum += count * count;
            Console.WriteLine("The sum of the first {0} squares is {1}", high, sum);
        }
    }
}
/*Nothing happens to this program as well as it does not terminate. 
 * Therefore, the user must terminate the program or abort the program.
 * N/B- The WriteLine statement comes before the while loop
 * and thus the WriteLine statement is never executed.
*/ 