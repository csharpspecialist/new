using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Properties_FieldsPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee lackey = new Employee();
            lackey.EnterEmpId();
                       

            
        }

    }


        class Employee
    {

        public int IdNumber { get; set; }
        public double Salary { get; set; }


        public void EnterEmpId()
        {
            Console.WriteLine("Enter an Employee Id to add to the Database");

            int realEmpNo;
            string tempEmpNo = ReadLine();

            while (!int.TryParse(tempEmpNo, out realEmpNo) || realEmpNo < 1 || realEmpNo > 1000)
            {

                Console.WriteLine("Not a valid entry \n " +
                    "Try again");
                tempEmpNo = ReadLine();

            }

            //below...the IdNumber property must be placed on the left side of the assignment statement
            //  realEmpNo = IdNumber will not work!!!!
            IdNumber = realEmpNo;
            Console.WriteLine($"The new assigned idNumber has now been changed to... {IdNumber}");
            ReadLine();


        }

    }





}
