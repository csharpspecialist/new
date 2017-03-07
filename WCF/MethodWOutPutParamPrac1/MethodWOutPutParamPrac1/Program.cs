using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MethodWOutPutParamPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 0 , secInt = 0;

            Console.WriteLine($"The first instance of your first entered value is now {firstInt} " +
               $"and the first instance of your second entered value is now {secInt}");
            Program p = new Program();

            p.Calc(out firstInt, out secInt);

            Console.WriteLine($"The value of your first entered value is now {firstInt} " + 
                $"and the value of your second entered value is now {secInt}");

            ReadKey();

        }

        //the name of the variables must match in lines
        //31 and lines 35 & 38 or this will not work!!!
        public void Calc(out int firstNum, out int secondNum)
        {

            Console.WriteLine("Enter a first # to add");
            firstNum = Convert.ToInt16(ReadLine());            

            Console.WriteLine("Enter a first # to add");
            secondNum = Convert.ToInt16(ReadLine());

             firstNum = (firstNum + secondNum); //reassigning val of firstnum 

             secondNum = (firstNum * secondNum);  //reassigning val of secondNum

        }

    }
}
