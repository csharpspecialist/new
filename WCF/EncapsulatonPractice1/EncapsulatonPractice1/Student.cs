using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulatonPractice1
{
    class Student
    {
        
        private int idNumber;
        private string lastName;
        private string firstName;

        public int GPA { get; set; }

        public int IdNumber
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

        public string LastName
        {

            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
            
        }

        public string FirstName
        {

            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }

        }

    }
}
