using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice2
{
    class Employee
    {
        public string FirstName { get; set; }

        private int idNumber;

        public int Idnumber
        {
            get { return idNumber; }
            set {
                if(value > 3000)
                {
                    idNumber = 2500;
                } else if(value <1)
                {
                    idNumber = 1;
                }

                }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int SocNumber { get; set; }

        string input;
        private int tuition;

        public int Tuition
        {
            get { return tuition; }

            set {
                while(!int.TryParse(input, out tuition) || tuition > 10000 || tuition < 1000  )
                {
                    Console.WriteLine("Your tuition value is not acceptable \n Please try another amount");
                    input = Console.ReadLine();

                }

            }
        }






    }
}
