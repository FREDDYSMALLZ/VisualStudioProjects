using System;

namespace MathLibrary
{
   public class Circle
    {
       public static void Main(string[] args)
        {
            Console.Write("Please enter the radius of the circle: ");
            String input = Console.ReadLine();
            double radius = double.Parse(input);

            double area_Circle = Math.PI * Math.Pow(radius, radius);
            double perimeter_Circle = 2 * (Math.PI) * radius;

            Console.WriteLine("A circle radius {0:F2} has area {1:F2} and a Permimeter of {2:F2}"
                , radius, area_Circle, perimeter_Circle);

            Console.ReadLine();
        }
    }
}