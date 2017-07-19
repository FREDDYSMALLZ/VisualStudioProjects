using System;
using System.IO;
namespace Example_4._10
{
    public class ConvertMenu
    {
        public static object IO { get; private set; }

        public static void Metric_To_English()
        {
            Console.WriteLine("Converting from meters to yards, feet and inches: ");
        }
        public static void English_T0_Metric()
        {
            Console.WriteLine("Converting from yards, feet and inches to meters: ");

        }
        public static void Main(string[] args)
        {
            Console.Write("Please enter your choice");
            String input = Console.ReadLine();
            int choice = int.Parse(input);
            
        }

    }
}