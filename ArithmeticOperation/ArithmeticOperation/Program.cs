using System;

namespace ArithmeticOperation
{
  public  class Arithmetic
    {
        //Program illustrates the manipulation of +,-,* and /

        public static void Main(string[] args)
        {
            int x = 25;
            int y = 14;
            int z = x + y;
            int w = x - y;
            int p = -y;

            Console.WriteLine("x + y = {0}, x - y = {1}, -y = {2}",
                z, w, p);
            Console.WriteLine("x * y = {0}, x / 7 = {1}, x % 7 = {2}",
                z, w, p);
        }
    }
}