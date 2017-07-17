/* Write C# program that checks a grade point
 * average the user inputs and outputs
 * congratulations, you made the honor roll if
 * the average is 3.5 and above,
 * but outputs Sorry, you are on probation if the 
 * average is below 2.0
*/

using System;

namespace GradePointAverage
{
   public class GradePointAverage
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Please enter your grade: ");
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.5)
            {
                Console.WriteLine("Congratulations, You made the honor roll.");

            }
            else if (grade <= 2.0)
            {
                Console.WriteLine("Sorry, You are on Probation. ");
            }
           // else
                //Console.WriteLine("Invalid grade Entry!");

            Console.ReadLine();
        }
    }
}