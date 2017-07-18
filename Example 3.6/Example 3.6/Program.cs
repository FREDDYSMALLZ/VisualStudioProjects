/*The program uses a while loop to compute
 * the sum of test scores
*/

using System;

namespace Example_3._6
{
   public class ScoreSum
    {
        //Returns the score entered by the user
        //Use a constructor class
        public static int Get_Score(String prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
        public static int UpdateTotal (int newValue, int subTotal)
        {
            subTotal += newValue;
            return subTotal;
        }

        public static void Main(string[] args)
        {
            int total = 0; //sum of the scores

            int score = Get_Score("Enter the first score, -1 to quit: ");

            while (score >= 0)
            {
                total = UpdateTotal(score, total);
                score = Get_Score("Enter the next score, -1 to quit:");

            }
            Console.WriteLine("The total is {0}", total);

            Console.ReadLine();
        }
    }
}