using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence3Layers
{
    class Manager: Employee
  //if Manager above inherits from employee
  // then 
    {
        new public string Greeting()
        {
            string greeting = base.Greeting();

            
            return greeting;
        }


    }
}
