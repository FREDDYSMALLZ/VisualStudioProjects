using System;

namespace OutputTable
{
  public  class OutPutTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0, -10} {1, 10}", "Names", "Numbers");
            Console.WriteLine("{0, -10} {1, 10}", "Sheila Kwamboka","1234");
            Console.WriteLine("{0, -10} {1, 10}", "Francis Manu","9876");
            Console.WriteLine("{0, -10} {1, 10}", "Fredrick Ondieki","28568");
            Console.WriteLine("{0, -10} {1, 10}", "Felix Matoke","91876");
            Console.WriteLine("{0, -10} {1, 10}", "Felix Manani","30876");
            Console.WriteLine("{0, -10} {1, 10}", "Pakko Anaya","56453");
        }
    }
}