using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Exercise_16
{
   public class Minimum
    {
        public static double UpdateMin(double newNumber, double minimumSofar)
        {
            if (newNumber > minimumSofar)
            {
                return newNumber;
            }
            else
                return minimumSofar;

        }
        public static int GetDouble(String prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());

        }
       public  static void Main(string[] args)
        {
            double minimumSofar = 0;
            double number = GetDouble("Enter the first number, -1 to quit: ");

            while (number >= 0)
            {
                minimumSofar = UpdateMin(number, minimumSofar);
                number = GetDouble("Enter the next number, -1 tp quit: ");

            }

            Console.WriteLine("The minimum is {0}", minimumSofar);


            Console.ReadLine();
        }
    }
}
