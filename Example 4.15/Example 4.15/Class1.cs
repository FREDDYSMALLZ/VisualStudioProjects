using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4._15
{
    public class IO
    {
        public static int GetInt(String prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
    }
}
