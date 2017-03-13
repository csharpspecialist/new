using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields_Properties
{
    class TwoEmployees
    {
        Employee dude = new Employee();
        Employee newEmployeeID = new Employee();

        public void ShowMain()

        {
           
            TwoEmployees cl = new TwoEmployees();
            
            //Employee anotherWorker = new Employee();
           // DisplayEmpData("First");
           // DisplayEmpData("Second");
           // string dave  = Convert.ToString(newEmployeeID.Idnumber = 12345);
           // DisplayEmpData(dave);

        }

     

        public void DisplayEmpData(string order)
        {
            
            Console.WriteLine($"\n {order} employee's message");
            dude.WelcomeMessage();
            Console.WriteLine("*********************");

        }


       
    }


}


 
