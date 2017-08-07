using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Exercise_12
{
   public  class RandomNumbers
    {
        public static void Main(string[] args)
        {
         
                int[] Array = new int[10000];
                Array[0] = 1;
                Array[1] = 2;
                Array[2] = 3;
                Array[3] = 4;
                Array[4] = 5;

                Random myRandom = new Random();
                int number = myRandom.Next(Array.Length);

                Console.WriteLine(Array[number]);


                Console.ReadLine();
            }
    }
}
