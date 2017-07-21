using System;

namespace Week3DSQ2
{
   public  class UnionArray
    {
        public static void MergeArray (int [] array_1, int array_2, int m, int n)
        {
            int i = 0;
            int j = 0;

            while (i < m && j < n)
            {
                if (array_1[i] < array_2)
                    Console.WriteLine(array_1[i++] + " ");
                else if (array_2 < array_1[i])
                    Console.WriteLine(array_2 + " ");
                else
                    Console.WriteLine(array_2 + " ");

            }
            while (i < m)
                Console.WriteLine(array_1[i++] + " ");
            while (j < n)
                Console.WriteLine(array_2 + " ");
        
        }
        
       public static void Main(string[] args)
        {
            int [] array_1 = { 1, 2, 3, 4, 5 };
            int [] array_2 = { 1, 3, 5, 7, 9 };

            int m = array_1.Length;
            int n = array_2.Length;

            Console.ReadLine();


        }
    }
}