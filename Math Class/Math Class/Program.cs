using System;

namespace Math_Class
{
   public class Square
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the length of the square: ");
            String input = Console.ReadLine();

            double length = double.Parse(input);
            //double area = length * length;
            double area = Math.Pow(length, length);

            Console.WriteLine("The area of the square is {0:F2} of length {1:F2}"
                , area, length);

            Console.ReadLine();
        }
    }
}