using System;
/* Static method with one inetger parameter and
 * let it return the remainder of that integer when divided 
 * by 7.
 * Initialize two variables x and y in the in the main method with variables
 * 73 and 16 respectively.
 * Call the remeinder method three times with arguments
 * x,y and x+y each time
 * displaying the results returned by the remainder.
*/

namespace StaticMethod
{
    public class staticMethod
    {
        public static int FindRemainder (int bNumber)
        {
            return bNumber % 7;
        }

       public static void Main(string[] args)
        {
            int x = 73;
            int y = 16;
            int result = 0;

            result = FindRemainder(x);
            Console.WriteLine("Passing a variable, x: {0}", result);

            result = FindRemainder(y);
            Console.WriteLine("Passing a variable, y: {0}", result);


            result = FindRemainder(x + y);
            Console.WriteLine("Passing an expression, x+y: {0}", result);


            
        }
    }
}