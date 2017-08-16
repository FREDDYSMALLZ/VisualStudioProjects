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
            
        }
        public static void Main(string[] args)
        {
            Spoon newSpoon = new Spoon();
            Arm newArm = new Arm();

            newSpoon.Bend();
            newArm.Bend();
            newSpoon.Eat();
            newArm.Eat();
            newSpoon.Raise();
            newArm.Raise();


            Console.ReadLine();
        }

     
    }

}
