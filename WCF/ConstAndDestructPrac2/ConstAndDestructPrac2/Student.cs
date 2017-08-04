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

        int important1;
        int important2;
        
        /* the constructor cannot have a return type!!!!!
         * below its properties are initializing the fields above*/
        public Student(string Firstname, string LastName)
        {

            this.fName = Firstname;
            this.lName = LastName;

        }
        public Student(int Important2, int Important1)
        {
            important1 = Important1;
            important2 = Important2; 
        }
        public void SecretNumbers()
        {
            Console.WriteLine($"Important number 1 is {important1} & Important # 2 is {important2}");
        }


        public void PrintFullName()
        {

            Console.WriteLine($"My first name is {fName} and my last name is {lName}.");

        }

        //destructor must be inside of class!!!
        ~Student()
        {
            System.Diagnostics.Trace.WriteLine("We are cleaning up our resources now!!!!");
            Console.ReadLine();
        }


    }


}


