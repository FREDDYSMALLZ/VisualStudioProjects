using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Exercise_26
{
    public class Calculate_PI
    {
        public static void Main(string[] args)
        {
            int Denomenator = 3;
            double Value_Of_PI = 4;
            int m = 3;

            while (Denomenator <=100)
            {
                if (m % 2 != 0)
                {
                    Value_Of_PI -= 1 / Denomenator;
                    m++;

                }
                else
                {
                    Value_Of_PI += 1 / Denomenator;
                    m++;
                }
                Denomenator += 2;

                Console.WriteLine(Value_Of_PI);
            }
            Console.ReadLine();
        }
    }
}
