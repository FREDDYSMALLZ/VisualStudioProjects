/*Write a program to convert meters to feet or inches.
 * There are 39.37 inches in 1 meter and
 * 12 inches in a foot.
 * If the length is less than 1 foot, 
 * report inches.
 * Show two digits after the decimal point.
*/

using System;

namespace Chapter_3_Exercise_14
{
    public class Convert
    {
        public static void Main(string[] args)
        {
            double lenth;
            double meter_to_inches; //Returns a value length in inches
            double  meter_inches = 39.27; // 1 meter is equal to 39.27 inches
            double inches_to_feet; // Returns a value lenth in feet
            double foot_inches = 12.0; // 1 foot is equal to 12 inches

            Console.Write("Please enter the length in meters: ");
            String input = Console.ReadLine();

            lenth = double.Parse(input);
            meter_to_inches = lenth * meter_inches; //Converts the length given in meters to inches
            inches_to_feet = meter_to_inches / foot_inches;

            Console.WriteLine(lenth + " " +
                "meters is {0:F2} inches or {1:F2} feet", meter_to_inches, inches_to_feet);

            Console.ReadLine();
        }
    }
}