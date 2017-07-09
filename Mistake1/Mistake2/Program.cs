using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Adds a WriteLine statement at the body
 * of the while loop
 * from the example given in Mistake1 program
*/
namespace Mistake2
{
    public class Mistake2
    {
        //Use a loop to compute the sum of squares
        static void Main(string[] args)
        {

            int sum = 0;   //Current value of the square and add
            int count = 1;

            Console.WriteLine("Enter the number of squares to sum:");

            int high = int.Parse(Console.ReadLine());

            while (count <= high) // Here the while loop body is made a block by use of curly braces
            {
                sum += count * count;
                Console.WriteLine("Sum is {0}", sum);
            }
            Console.WriteLine("The sum of the first {0} squares is {1}", high, sum);

        }
    }
}
/*The body of the While loop is made into a block. 
 * The statements are enclosed in curly braces
 * because the while loop is a single assignment statement.
 * The program continues to run until it is aborted.
 * It is clear that the while loop does not terminate.
 * N/B-The count is not incremented after adding the next square to the sum.
*/