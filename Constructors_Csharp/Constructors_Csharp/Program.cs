using System;

namespace Constructors_Csharp
{
    public class Vehicle
    {
        public int MaxSpeed;
        public double EngineSize;
        public String Name;

        public Vehicle()// Default constructor
        {
            MaxSpeed = 200;
            EngineSize = 3.8;
            Name = "DodgeCharger";
        }
        public Vehicle(int MaxSpeed, double EngineSize, String Name)//Overloaded Constructor
        {
            this.Name = Name;
            this.MaxSpeed = MaxSpeed;
            this.EngineSize = EngineSize;
        }
        public override string ToString()
        {
            return (String.Format("({0}, {1}, {2}", Name, MaxSpeed, EngineSize));

        }
        public static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
            Vehicle myVehicle2 = new Vehicle();
            myVehicle2.Name = "ChevroletImpala";
            myVehicle2.MaxSpeed = 120;
            myVehicle2.EngineSize = 2.6;

           /* Console.WriteLine("My first vehicle has the following qualities {0}; "
                , myVehicle);
            Console.WriteLine("My second vehicle has the following qualities {0}; "
                , myVehicle2);

            */

            Console.WriteLine("My first vehicle is called {0} of Engine size {1}" +
                " and has a Maximum speed of {2} miles per hour.",
                myVehicle.Name, myVehicle.EngineSize, myVehicle.MaxSpeed);
            Console.WriteLine("My second vehicle is called {0} of Engine size {1}" +
                " and has a Maximum speed of {2} miles per hour.",
                myVehicle2.Name, myVehicle2.EngineSize, myVehicle2.MaxSpeed);

            Console.ReadLine();
        }
    }
}