using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Adds a WriteLine statement at the body
 * of the while loop
 * from the example given in Mistake1 program
 * Modifys mistake 2 to increment the count
*/
namespace Mistake3
{
    public class Mistake3
    {
        //Use a loop to compute the sum of squares
        public static void Main()
        {

            int sum = 0;   //Current value of the square and add
            int count = 1;

            Console.Write("Enter the number of squares to sum:");

            int high = int.Parse(Console.ReadLine());

            while (count <= high) // Here the while loop body is made a block by use of curly braces
            {
                sum += count * count;
                count++;
               // Console.WriteLine("Sum is {0}", sum);
            }
            Console.WriteLine("The sum of the first {0} squares is {1}", high, sum);

        }
    }
}
