 using System;

namespace Chapter_5_Exercise_22
{
   public  class VendingMachine
    {
       private int Quantity;
       private double Cost_Of_Cofee;
       private double Amount_Of_Money;
        private int Coffee_Cups;

        public VendingMachine()
        {
            Quantity = 10;
            Cost_Of_Cofee = 0.50;
        }
        public VendingMachine(int NumberOfCoffeeCups, double CostOfCofee, double AmountOfMoney)
        {
            Quantity = NumberOfCoffeeCups;
            Cost_Of_Cofee = CostOfCofee;
            Amount_Of_Money = AmountOfMoney;

        }
        public void Menu()
        {
            this.Quantity = 10;
            this.Cost_Of_Cofee = 0.50;
        }
        public void Insert(int quarters, int dimes, int nickels)
        {
            Amount_Of_Money = quarters;
            Amount_Of_Money = dimes;
            Amount_Of_Money = nickels;
        }
        public void Select()
        {
            if (Amount_Of_Money >= Cost_Of_Cofee)
            {
               
            }
            else
            {

            }
         

        }
        public void Refund()
        {
            double refund = Amount_Of_Money - (Cost_Of_Cofee * Coffee_Cups);
        }
        public static void Main(string[] args)
        {
            VendingMachine myVendingMachine = new VendingMachine();
            myVendingMachine.Coffee_Cups = 35;

            Console.WriteLine(myVendingMachine.Coffee_Cups);

            Console.ReadLine();
        }
    }
}