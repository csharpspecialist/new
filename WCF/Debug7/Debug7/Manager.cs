using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Debug7
{
    class Manager
    {
        static void Main(string[] args)
        {           
            
            DebugSeven1 sev = new DebugSeven1();
            

            sev.ShowWebAddress(); //bypasses privateness of displayWebAddress method
            
            Console.WriteLine($"{sev.DisplayWebAddress(sev.num) }"); //calls the 1st overloaded DisplayWebAddresses implementation by passing in sev.num(which is a public property)
            Console.WriteLine($"{sev.DisplayWebAddress(sev.thinker,sev.smart) }"); //calls the 2nd overloaded DisplayWebAddresses implementation by passing in sev.things and sev.smart (which is a public properties)


            // sev.DisplayWebAddress();
            ReadKey();

        }
    }
}
