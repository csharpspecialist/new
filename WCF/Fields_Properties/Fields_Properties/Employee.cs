using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields_Properties
{
    class Employee
    {

        private int idNumber;
        public int Idnumber
        {
            get
            {
                return idNumber;
            }

            set
            {
                idNumber = value;
            }
        }

        public int reno = 1;


        public void WelcomeMessage()
        {
            Console.WriteLine($"Welcome from employee {idNumber}");
            Console.WriteLine("How can I help you");
            ReadKey();
        }

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

            Idnumber = realEmpNo ;
            Console.WriteLine($"The new assigned idNumber has now been changed to... {realEmpNo}");
            ReadLine();


            Employee assigner = new Employee();

            //assigner.idNumber = realEmpNo;

            assigner.Idnumber = realEmpNo; 



        }

    }
}
