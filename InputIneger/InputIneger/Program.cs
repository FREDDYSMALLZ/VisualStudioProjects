using System;

namespace InputIneger
{
   public class InputIneger
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an ineger number: ");
            int number_1 = int.Parse(Console.ReadLine());

            int number_2 = number_1 + number_1;

            Console.WriteLine("Twice the number is {0}", number_2);
            Console.WriteLine("The number is {0} and twice it is {1}", number_1, number_2);
            Console.WriteLine("Twice the number is {0} and the number is {1}", number_2, number_1);
        }
    }
}