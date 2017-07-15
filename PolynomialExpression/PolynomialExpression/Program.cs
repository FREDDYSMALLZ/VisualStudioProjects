/* Write a ststic method with one integer
 * parameter x that returns the value of 
 * the polynomial (Program design exercise 18).
 * Call the method twice from the main method, each time 
 * reading in the vale of x and
 * displaying the result.
*/

using System;

namespace PolynomialExpression
{
   public  class PolynomialExpression
    {
        public static int polynomial(int x)
        {
            int result = 4 * (x * x) + 3 * x - 5;
            return result;
        }
       public static void Main(string[] args)
        {
            int x = 5;
            int PolynomialExpression = polynomial(x);

           Console.WriteLine("{0} is the result of the polynomial expression:",
               PolynomialExpression);

            Console.WriteLine("The result of expression is {0} when {1} is used in the expression."
                , PolynomialExpression, x);
        }
    }
}