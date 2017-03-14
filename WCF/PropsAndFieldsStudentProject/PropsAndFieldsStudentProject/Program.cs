using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsAndFieldsStudentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oneScholar = new Student();
            Student twoScholar = new Student();

            oneScholar.IdNumber = 100;
            oneScholar.LastName = "Curry";

            twoScholar.IdNumber = 200;
            twoScholar.LastName = "Wayne";

        }
    }
}
