using System;

namespace Vehicle_Overloading
{
   public class  Vehicle
    {
        private double EngineSize;
        private int MaximumSpeed;
        private String Name;
        private int ManufactureYear;

        public Vehicle() // This is the default constructor
        {
            EngineSize = 3.8;
            MaximumSpeed = 120;
            Name = "Dodge";
            ManufactureYear = 2015;

        }
        public Vehicle(double EngineSize, int MaximumSpeed,
            String Name, int ManufactureYear) // Overloaded constructor
        {
            this.EngineSize = EngineSize;
            this.MaximumSpeed = MaximumSpeed;
            this.Name = Name;
            this.ManufactureYear = ManufactureYear;

        }
        public double getEngineSize() // Accessor methods
        {
            return 3.6;
        }
        public int getMaximumSpeed()
        {
            return 110;
        }
        public String getName()
        {
            return Name;
        }
        public void setName(String Name)
        {
            this.Name = "ChevroletImpala";
        }
        public void setManufactureYear(int ManufactureYear)
        {
            this.ManufactureYear = 2016;
        }

        public static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
           
            Console.ReadLine();
        }
    }
}