/*Evaluating AND, OR, and NOT expressions
 * involving height and weight measurements.
*/

using System;

namespace Example_4._1
{
   public class Measure
    {
       public static void Main(string[] args)
        {
            double height;       
            Console.Write("Please enter the height in inches : ");           
            String intput = Console.ReadLine();
            height = double.Parse(intput);

            double weight;
            Console.Write("Please enter the weight in pounds: ");
            weight = double.Parse(intput);

            Console.Write("height < 65  && (weight < 130  is ");
            Console.WriteLine((height <65) && (weight < 130 ));
            Console.Write("height < 65  || (weight < 130  is ");
            Console.WriteLine((height < 65) || (weight < 130));
            bool heavy = (weight > 250);
            Console.WriteLine("heavy is " + heavy);
            Console.WriteLine("!heavy is " + !heavy);


            Console.ReadLine();
        }
    }
}