using System;
using System.Collections.Generic;
using System.Text;

namespace DEMO_B11
{
    enum WeekDay
    {
        Monday = 1,
        Tuesday = 2,
        Sunday = 7
    }

    enum Gender
    {
        Male,
        Female
    }

    class SavingAccountCustomer : Customer
    {
        public string num = null;

        public WeekDay AccountOpenDay; // add account open day.
        public int Gender;

        public override void ATMLimitCalculate()
        {
            Console.WriteLine("SavingAccount ATM Limit");
        }

        public override void Facility()
        {
            Console.WriteLine("SavingAccount Facility");
        }

        public int Add(int a, int b, params int[] number)
        {
            var result = a + b;
            foreach (var num in number)
            {
                result = result + num;
            }
            return result;
        }


        public double Add(double a, double b, double c = 0)
        {
            var result = a + b + c;
            
            return result;
        }
    }

    class CurrentAccountCustomer : Customer
    {
        public override void ATMLimitCalculate()
        {
            Console.WriteLine("CurrentAccountCustomer ATM Limit");
        }

        public override void Facility()
        {
            Console.WriteLine("CurrentAccountCustomer Facility");
        }
    }

    class LoanAccountCustomer : Customer
    {
        public override void ATMLimitCalculate()
        {
            Console.WriteLine("LoanAccountCustomer ATM Limit");
        }

        public override void Facility()
        {
            Console.WriteLine("LoanAccountCustomer Facility");
        }
    }

    class BusinessAccountCustomer : Customer
    {
        public override void ATMLimitCalculate()
        {
            throw new NotImplementedException();
        }

        public override void Facility()
        {
            throw new NotImplementedException();
        }
    }
}
