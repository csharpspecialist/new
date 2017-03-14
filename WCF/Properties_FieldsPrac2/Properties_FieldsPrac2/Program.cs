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
            Teachers summer = new Teachers();
            summer.Grade();
            Environment.Exit(0);

           // summer.StaffMember();
           // lackey.EnterEmpId();

            summer.ShowEmployeeInfo(lackey);
            
        }

    }

        class Employee
    {

        public int IdNumber { get; set; }
        public double Salary { get; set; }

        public int Department { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }
        

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

    class Teachers
    {
        Employee number8 = new Employee();
        Employee scholarOne = new Employee();

        public void Grade()
        {

            number8.FName = "Carol";
            number8.LName = "Miller";
            number8.IdNumber = 2000;
            number8.Salary = 72000;
            number8.Department = 5;

            scholarOne.FName = "Dave";
            scholarOne.LName = "Frost";
            scholarOne.IdNumber = 1001;
            scholarOne.Salary = 50000;
            scholarOne.Department = 7;

            ShowEmployeeInfo(number8);
            Console.WriteLine("");
            Console.WriteLine("*****************");
            ShowEmployeeInfo(scholarOne);
            Console.WriteLine("");
            Console.WriteLine("*****************");
            ReadLine();

        }

        public void ShowEmployeeInfo(Employee emp)
        {
            Console.WriteLine($"The information for employee # : {emp.IdNumber} is \n" +
                $"First Name : {emp.FName} \n Last Name : {emp.LName} \n Dept # : {emp.Department}");     
                       
        }

        
        //below is just practice with an enum
        public void StaffMember()
        {
            Console.WriteLine("Which Staff member gets paid the most \n" +
                " 1. Professors \n 2. Dean's \n 3. Administrators \n " 
                + "4. Assistants  \n 5. Janitors ");
            //int staffPerson = Convert.ToInt16( ReadLine());
            string message = "";


            int mine = Convert.ToInt16(ReadLine());
            
            switch ((Faculty)mine)
            {
                case Faculty.PROF:
                    message = "Prof's are OK people";
                    break;
                case Faculty.DEAN:
                    message = "Dean's need more love";
                    break;
                case Faculty.ADMIN:
                    message = "Administrator's need to attend more classes";
                    break;
                case Faculty.ASSISTANT:
                    message = "Assistants assist in helping students";
                    break;
                case Faculty.JANITOR:
                    message = "Janitor's Have unthankful jobs";
                    break;
                default:
                    message = "That is not a valid answer";
                    break;

            }
            Console.WriteLine(message);
            ReadLine();

        }

    }

    enum Faculty
    {
        PROF = 1,
        DEAN,
        ADMIN,
        ASSISTANT,
        JANITOR

    }

}
