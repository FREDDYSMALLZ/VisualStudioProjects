/*To convert degrees Centigrade to
 * degrees Fhrenheit, the following
 * formula is used
 * F = 9C/5 + 32;
*/

using System;

namespace Example_3._5
{
  public  class Temperature
    {
       public static void Main(string[] args)
        {
            double hotC;
            double coldC;
            double hotF;
            double coldF;

            Console.Write("Please Enter a hot temperature in celcius: ");
            String input = Console.ReadLine();
            hotC = double.Parse(input);
            hotF = 9.0 * (hotC / 5.0) + 32.0;//From the formula given in the text

            Console.WriteLine("The Fahrenheiht temperature is {0:F1}", hotF);

            Console.Write("Please Enter a cold temperature in celcius: ");
            input = Console.ReadLine();
            coldC = double.Parse(input);
            coldF = 9.0 * (coldC / 5.0) + 32.0; // From the above given formula

            Console.WriteLine("The Fahrenheiht temperature is {0:F1}", coldF);

            Console.ReadLine();



        }
    }
}