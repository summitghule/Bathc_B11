using System;
using System.Collections.Generic;
using System.Text;

namespace DEMO_B11
{
    public abstract class Customer
    {
        // Passbook, PrintPassbook, Login

        // ATMLimitCalculate, Facility 
        // member

        int accountNumber;

        public void Passbook()
        {
            Console.WriteLine("Passbook");
        }

        public void PrintPassbook()
        {
            Console.WriteLine("Print Passbook");
        }

        public void LoginUser()
        {
            Console.WriteLine("Login User..!!");
        }

        public abstract void ATMLimitCalculate();

        public abstract void Facility();

    }
}
