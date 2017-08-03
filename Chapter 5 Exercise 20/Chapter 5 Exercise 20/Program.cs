using System;

namespace Chapter_5_Exercise_20
{
   public class Warehouse
    {
        private int radios;
        private int televisions;
        private int computers;

        public Warehouse()
        {
            radios = 0;
            televisions = 0;
            computers = 0;
        }
        public Warehouse (int Radios, int Televisions, int Computers)
        {
            radios = Radios;
            televisions = Televisions;
            computers = Computers;
        }
        public int  getRadios()
        {
            return radios;
        }
        public int getTelevisions()
        {
            return televisions;
        }
        public int getComputers()
        {
            return computers;
        }
        public void ADD(int Radios, int Televisions, int Computers)
        {
            radios += Radios;
            televisions += Televisions;
            computers += Computers;
        }
        
        public  static void Main(string[] args)
        {
            Warehouse myWarehouse = new Warehouse();
            myWarehouse.radios = 400;
            myWarehouse.televisions = 320;
            myWarehouse.computers = 1500;

            Warehouse myWarehouse2 = new Warehouse(120, 560, 200);
            

            Console.WriteLine("My Warehouse has {0} radios, {1} televisions and {2} computers: "
                ,myWarehouse.radios, myWarehouse.televisions, myWarehouse.computers);

            Console.ReadLine();
        }
    }
}