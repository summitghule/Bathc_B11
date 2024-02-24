

using System;
using static DEMO_B11.Program.Student;

namespace DEMO_B11
{
    class Program
    {
        // Static, - Member, Method, Class

        // non-static Class
        //1. Member/method static or nonstatic,

        // static Class
        //1. Member/method static,


        public class Student : IDisposable
        {

            public System.Int32 RollNo; //123


            private Student()
            {
                Console.WriteLine("Private Constructor Called...!!!");
            }

            //public Student()
            //{
            //    Console.WriteLine("Constructor Called...!!!");
            //}


            public Student(int rollNo)
            {
                RollNo = rollNo;

                Console.WriteLine("Parameterized Constructor Called... Roll NO {0}!!!", this.RollNo);
            }


            public Student(int rollNo, string name)
            {
                RollNo = rollNo;

                Console.WriteLine("Parameterized Constructor Called...!!! Roll - {0}, Name - {1}", rollNo, name);
            }

            public Student(Student obj)
            {
                Console.WriteLine("COpy Constructor Called... Roll NO - {0}!!!", obj.RollNo);
            }

            static double pi;

            static Student()
            {
                pi = 3.14;
                Console.WriteLine("Static Constructor  Called...PI {0}!!!", pi);
            }

            public void Print()
            {
                Console.WriteLine("Print from student class");

            }

            public void Dispose()
            {
                Console.WriteLine("Dispose Called...!!!");
            }

            public class EnggStudent : Student
            {

                Student objStudent;

                public EnggStudent()
                {
                    objStudent = new Student();
                }

            }

            ~Student()
            {

                Console.WriteLine("Destructor Called...!!!");
            }



        }

        struct Coordinate
        {
            public int latitude;
            public int longitude;

            public void Display()
            {
                Console.WriteLine("Lantitude: {0} , Longitude: {1}", latitude, longitude);
            }

        }



        static void Main(string[] args)
        {

            SavingAccountCustomer savingAccount;


            try
            {
                savingAccount = new SavingAccountCustomer();

                if (savingAccount != null)
                {
                    savingAccount.num = "10";
                    savingAccount.AccountOpenDay = WeekDay.Monday;  // Monday

                    savingAccount.Passbook();
                    savingAccount.PrintPassbook();
                    savingAccount.LoginUser();
                    savingAccount.ATMLimitCalculate();
                    savingAccount.Facility();

                    var sum = savingAccount.Add(10, 20, 5, 10, 50);
                   
                    
                    var sum1 = savingAccount.Add(10.1, 20.1);

                }


                int a = 0;
                int b = 10;

                if (a == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                else
                {
                    var result = b / a;
                    Console.WriteLine("Result = {0}", result);
                }


                //var result = a == 0 ? 0 : b / a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException...!!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException.....!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception...!!!");
            }

            finally
            {

                savingAccount = null;

                Console.WriteLine("Always execute...!!!");

            }



            Customer loanAccount = new LoanAccountCustomer();
            loanAccount.Passbook();
            loanAccount.PrintPassbook();
            loanAccount.LoginUser();
            loanAccount.ATMLimitCalculate();
            loanAccount.Facility();


            //var obj1 = new Student(123); // Parameterized
            //obj1.Dispose();


            //var structObj = new Coordinate();
            //structObj.latitude = 10;
            //structObj.longitude = 12;
            //structObj.Display();

            //var obj = new Student();  // default
            //obj.Print();

            //var obj2 = new Student(101, "testUser"); // Parameterized

            var savingAccount1 = new SavingAccountCustomer();

            savingAccount1.AccountOpenDay = WeekDay.Sunday; // SUNDAY
            savingAccount1.Gender = (int)Gender.Female;

            Console.WriteLine("Hello World!");

            //Student
            //RollNo  - 121,122,123 or B110001, B110002
            //Name - abc xyz
            //Address - Flat NO - 12, Society Name, Road Name - sector 85
            //Contact - 9878963652
            //BloodGroup - AB+ve, AB-ve
            //EmailId - test@test.com
            //DOB - 18/09/2000
            //HomeLocation - 18.07, 19.00
            //LastYearPecentage - 80.45
            // Gender - Male, Female
            // DOB_DAY - Sunday, M, T...Sat







            //Car marutiSwift = new Car();
            //marutiSwift.Height = 90000;
            //marutiSwift.Color = "RED";
            //marutiSwift.Start("");

            //marutiSwift.Stop();



            //Car hyudaiVerna = new Car();
            //hyudaiVerna.Height = 1700;
            //hyudaiVerna.Color = "White";
            //hyudaiVerna.Start(1);

            //hyudaiVerna.Stop();







        }
    }
}
