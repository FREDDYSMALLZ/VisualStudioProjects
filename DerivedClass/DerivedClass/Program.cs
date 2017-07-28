using System;

namespace DerivedClass
{
   public  class Person
    {
        public void setFirst_name(String First_name)
        {
            First_name = "Fredrick";
        }
        public void setLast_name(String Last_name)
        {
            Last_name = "Ondieki";
        }
        public void setSSN(int SSN)
        {
            SSN = 123458232;
        }
        public void setID_Number(int ID_Number)
        {
           ID_Number = 28568;
        }
        protected String First_name, Last_name;
        protected int SSN, ID_Number;

        public class Employee: Person //Derived class
        {
            public String getFirst_name()
            {
                return First_name;
            }
            public String getLast_name()
            {
                return Last_name;
            }
            public int getSSN()
            {
                return SSN;
            }
            public int  getID_Number()
            {
                return ID_Number;
            }

        }
       
       public static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            myEmployee.First_name = "Francis";
            myEmployee.Last_name = "Manuel";
            myEmployee.SSN = 234567863;
            myEmployee.ID_Number = 65765;

            Console.WriteLine("The new employees data is {0}", myEmployee.ID_Number);

            Console.ReadLine();
            
        }
    }
}