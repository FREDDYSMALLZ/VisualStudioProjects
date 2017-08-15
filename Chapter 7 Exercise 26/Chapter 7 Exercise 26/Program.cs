using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Exercise_26
{
    public class SelectionSort_Timing
    {
        private int[] item;

        public SelectionSort_Timing()
        {
        }

        public SelectionSort_Timing(int[] i)
        {
            item = i;
        }

        public static void Main(string[] args)
        {
            int arraySize = 5;
            int[] Array = new int[5] { 1, 9, 5, 4, 7 };
            Console.WriteLine("The List of the Array to be sorted is : ");

            SelectionSort_Timing s = new SelectionSort_Timing();
            int starttime = System.Environment.TickCount;
            //s.Sort();
            int stoptime = System.Environment.TickCount;

            Console.WriteLine("The time used for sorting in milliseconds is {0}", stoptime - starttime);

            try
            {
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine(Array[i]);
                }
                int tmp;
                int minimumKey;

                for (int j = 0; j < arraySize - 1; j++)
                {
                    minimumKey = j;

                    for (int k = j + 1; k < arraySize; k++)
                    {
                        if (Array[k] < Array[minimumKey])
                        {
                            minimumKey = k;
                        }
                    }

                    tmp = Array[minimumKey];
                    Array[minimumKey] = Array[j];
                    Array[j] = tmp;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            Console.WriteLine("The Array list after  Sorting  is {0} ");


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Array[i]);
            }

            Console.ReadLine();
        }

        
        }
    }


