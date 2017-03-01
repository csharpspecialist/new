using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugEx4_1
{
    class Debug4_2
    {

        public void Debug2()
        { 


            int num1, num2, num3;
         // string snum1, snum2, snum3;
          Write("Enter first number ");
            num1 = Convert.ToInt32(ReadLine());
          Write("Enter second number ");
            num2 = Convert.ToInt32(ReadLine());
          Write("Enter third number ");
            num3 = Convert.ToInt32(ReadLine());


      
          if(num1 < num2 && num2 < num3)
             WriteLine("Numbers are in sequential order");
          else if(num1 > num2 && num2 > num3)
                WriteLine("Numbers are in reverse order");
             else
                WriteLine("Numbers are in neither sequential nor reverse order");

        }

    }
}
