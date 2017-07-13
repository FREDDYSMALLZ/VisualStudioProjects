using System;

namespace OutPutFormat
{
    public class OutputFormat
    {
        static void Main(string[] args)
        {
            int number1 = 35;
            int number2 = 2 * (number1);

            Console.WriteLine("The number is {0} and twice the number is {1}",
                number1, number2);
            Console.WriteLine("{0} is the number and {1} is its double",
                number1, number2);
            Console.WriteLine("Twice the number is {1} and the number is {0}",
                number1, number2);
            Console.WriteLine("The first is {0:C} and twice the number is {1:C}",
                number1, number2);
        }
    }
}