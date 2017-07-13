using System;

namespace InputName
{
   public  class InputName
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name:");

            String name = Console.ReadLine();

            Console.WriteLine("Your name is {0}", name);
        }
    }
}