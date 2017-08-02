using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Employee e = new Employee();

            e.FirstName = "Carol";
            e.LastName = "Danvers";
            e.Idnumber = 5000;
            e.SocNumber = 5552300;
            e.Tuition = 500;
            p.DisplayInfo(e);


        }


        public void DisplayInfo(Employee emp)
        {
            Console.WriteLine($"My first name is {emp.FirstName}, my last name is {emp.LastName}, my ID number is {emp.Idnumber} and my Soc Number is {emp.SocNumber}");

            Console.ReadLine();
        }


    }
}
