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
            myWarehouse.ADD(50, 345, 20);

            Warehouse myWarehouse2 = new Warehouse(120, 560, 200);
            myWarehouse2.ADD(40, 20, 10);
           
            Console.WriteLine("My Warehouse has {0} radios, {1} televisions and {2} computers: "
                ,myWarehouse.radios, myWarehouse.televisions, myWarehouse.computers);

            Console.WriteLine("My Warehouse2 has {0} radios, {1} televisions and {2} computers: "
               , myWarehouse2.radios, myWarehouse2.televisions, myWarehouse2.computers);



            Console.ReadLine();
        }
    }
}