using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsAndFieldsStudentProject
{
    class Student
    {

        private int idNumber;
      //  private string lastName;
      //  private string firstName;
        private double gradePointAvg;

        public const double  HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        public string LastName { get; set; }

        public string FirstName { get; set; }


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

        public double GradePointAvg
        {

            get
            {
                return gradePointAvg;
            }

            set
            {
                if (value >= HIGHEST_GPA)
                    gradePointAvg = 2.1;
                else if (value < 0)
                    gradePointAvg = 0.1;
                else
                    gradePointAvg = value; 
            }

        }    
        

    }
}
