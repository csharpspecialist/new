﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PassArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {

            /*this one is kind of tricky... put a break point on line 31 (where the 2nd loop starts)
       * and step through the code using F11 to see how this works
        */
            Program p = new Program();
           
            int[] someNums = { 10, 12, 25, 35 };
            int x;

            Console.WriteLine("At the beginning of the Main method");

            for ( x = 0; x < someNums.Length; ++x)
            {
                Console.WriteLine( "{0,6}", someNums[x]);
            }  //0,6 is the position that the text lines up on the screen
            //it does not do anything else
            Console.WriteLine();
            for (x = 0; x < someNums.Length; x++)
            {
                p.MethodGetsOneInt(someNums[x]);
            }
            Console.WriteLine("At the end of the Main method.......");

            for (x = 0; x < someNums.Length; ++x)
            {
                Console.WriteLine("{0,6}", someNums[x]);
            }
            ReadKey();
        }
      

        public void MethodGetsOneInt(int oneVal)
        {
            
            Console.WriteLine($"MethodGetsOneInt {oneVal}");
            oneVal = 333;
            Console.WriteLine($"           After change {oneVal}");
        }
    }
}
