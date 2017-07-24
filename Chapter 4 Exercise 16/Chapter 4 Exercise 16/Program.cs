using System;

namespace Chapter_4_Exercise_16
{
   public  class SquareRoot
    {
        
       public static void Main(string[] args)
        {
            Console.Write("Please enter the number to be Square rooted: ");
            String input = Console.ReadLine();
             double number = double.Parse(input);
             double r = 1.0;
             double estimate_1 = number / r;
             double average = (estimate_1 + r) / 2;
             double estimate_2 = number / average;
             double squareRoot = (average + estimate_2) / 2;
   
            Console.WriteLine("The Square root of number {0:F2} is ", squareRoot);

            Console.ReadLine();

        }
    }
}