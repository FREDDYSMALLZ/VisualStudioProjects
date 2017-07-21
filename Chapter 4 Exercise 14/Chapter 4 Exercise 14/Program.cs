/* Write a C# program that inputs the ardius of a circle
 * and outputs its circumference.
*/

using System;

namespace Chapter_4_Exercise_14
{
   public class Circle
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the radius of the circle: ");
            String input = Console.ReadLine();
            double radius = double.Parse(input);

            double circumference = Math.PI * 2 * (radius);

            Console.WriteLine("A circle of radius {0:F2} has a circumference of {1:F2} "
                , radius, circumference);


            Console.ReadLine();
        }
    }
}