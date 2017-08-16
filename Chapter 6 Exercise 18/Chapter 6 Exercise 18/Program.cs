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
        void Raise();
        void Eat();

    }
    
   public class Spoon: IBendable
    {
        public Spoon()
        {

        }
        public void Eat()
        {
            Console.WriteLine("The Spoon is used for eating.");

        }
        public void Raise()
        {
            Console.WriteLine("The Spoon Can be raised.");
        }
        public void Bend ()
        {
            Console.WriteLine("The Spoon can be bent.");
        }
        public class Arm : IBendable
        {
            public Arm()
            {

            }
            public void Bend()
            {
                Console.WriteLine("The Arm can bend.");

            }
            public void Raise()
            {
                Console.WriteLine("The Arm can be raised.");

            }
            public void Eat()
            {
                Console.WriteLine("The arm is used to hold the spoon when eating.");
            }
        }
        public class TestIBendable
        {
            public static void Spoon_(IBendable B)
            {
                B.Bend();
                B.Eat();
                B.Raise();
                
            }
        }
        public static void Main(string[] args)
        {
            Spoon newSpoon = new Spoon();
            Arm newArm = new Arm();

            Spoon_Arm(newSpoon);
            Console.WriteLine();
            Spoon_Arm(newArm);           
        }

        private static void Spoon_Arm(Arm newArm)
        {
            
        }

        private static void Spoon_Arm(Spoon newSpoon)
        {
            Console.ReadLine();
        }
    }

}
