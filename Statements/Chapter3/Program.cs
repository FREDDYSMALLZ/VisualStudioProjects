using System;

namespace Chapter3
{
   public  class Overtime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hours you worked this week:");
            int hours = int.Parse(Console.ReadLine());

            if (hours > 40)
                Console.WriteLine("You worked overtime this week.");
            Console.WriteLine("You worked {0} hours.", hours);

        }
    }
}