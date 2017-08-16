using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Exercise_18
{
    public interface IBendable
    {
        void Bend();

    }
    
   public class Spoon: IBendable
    {
        public void Eat()
        {
            Console.WriteLine("The Spoon is used for eating.");

        }
        public class Arm : IBendable
        {
            public void Bend()
            {
                Console.WriteLine("The Arm can bend.");

            }
            public void Raise()
            {

            }
        }
        public class TestIBendable
        {
            public static void Bend(IBendable B)
            {
                B.Bend();
                
            }
        }
        public static void Main(string[] args)
        {
            Spoon newSpoon = new Spoon();
            Arm newArm = new Arm();

            Bend(newSpoon);

            Console.WriteLine("");
            Bend(newArm);
        }

        private static void Bend(Arm newArm)
        {
            
        }

        private static void Bend(Spoon newSpoon)
        {
            
        }

        public void Bend()
        {
            Console.ReadLine();
        }

    }

}
