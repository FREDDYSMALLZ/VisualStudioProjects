/* The program is a modification of example
 * 4.3 in the textbook which uses a swtch ststements
 * instead of th nested if-else ststements
*/

using System;

namespace Example_4._3
{
    public class Score
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter a test score or -1 to quit: ");
            int score = int.Parse(Console.ReadLine());
            //int mark = score / 10;
            switch (score)
            {
                case 0:
                    (score <= 50).ToString();
                    Console.WriteLine("F");
                    break;
                case 1:
                    Console.WriteLine("F");
                    break;
                case 2:
                    Console.WriteLine("F");
                    break;
                case 3:
                    Console.WriteLine("F");
                    break;
                case 4:
                    Console.WriteLine("F");
                    break;
                case 5:
                    Console.WriteLine("F");
                    break;
                case 6:
                    Console.WriteLine("F");
                    break;
                case 7:
                    Console.WriteLine("F");
                    break;
                case 8:
                    Console.WriteLine("F");
                    break;
                case 9:
                    Console.WriteLine("F");
                    break;
                case10:
                    Console.WriteLine("F");
                    break;










            }


            Console.WriteLine(" ");
        }
    }
}