using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndDestructPrac2
{
    class Student
    {
        //these must be fields!!!!! not Properties
        string fName;
        string lName;
        
        /* the constructor cannot have a return type!!!!!
         * it is initializing the fields above*/
        public Student(string Firstname, string LastName)
        {
            this.fName = Firstname;
            this.lName = LastName;

        }


        public void PrintFullName()
        {

            Console.WriteLine($"My first name is {fName} and my last name is {lName}.");

        }
    }
}
