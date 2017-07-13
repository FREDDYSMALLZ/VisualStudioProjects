using System;

/*Write a program to enter the height and
 * the width of a rectangle from the
 * keyboard and outputs the 
 * area of the rectangle
*/

namespace AreaOfRectangle
{
   public class AreaOfRectangle
    {
      public static void Main(string[] args)
        {
            Console.Write("Enter the Width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter the Height of the rectangle:");
            double height = double.Parse(Console.ReadLine());

            double area_Of_Rectangle = width * height;

           // Console.WriteLine("The area of the rectange is {0} units with the width of {1} and a height of {2}",
              //  area_Of_Rectangle, width, height);

            Console.WriteLine("A rectangle of width {0} and height {1}, its area is {2} units",
                width, height, area_Of_Rectangle);
        }
    }
}