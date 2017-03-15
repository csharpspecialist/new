using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PropsAndFieldsStudentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string show;
            Student oneScholar = new Student();
            Student twoScholar = new Student();

            oneScholar.IdNumber = 100;
            oneScholar.LastName = "Wayne";
            oneScholar.FirstName = "Bruce";
            oneScholar.GradePointAvg = 4.2;

            twoScholar.IdNumber = 200;
            twoScholar.FirstName = "Tony";
            twoScholar.LastName = "Stark";
            twoScholar.GradePointAvg = -5;

            p.ShowGpa(oneScholar);
            p.ShowGpa(twoScholar);


           
            ReadLine();
            
        }

        public void ShowGpa(Student st)
        {

            Console.WriteLine($"The statistics of student # {st.IdNumber} \n are {st.FirstName}, {st.LastName}" + $" who has a GPA of {st.GradePointAvg} \n");


           
        }

    }
}
