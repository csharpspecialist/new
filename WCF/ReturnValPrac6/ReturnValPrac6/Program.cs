using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValPrac6
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            int total;
            Console.WriteLine("Enter a first int val");

            int val1 = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter a 2nd int val");

            int val2 = Convert.ToInt16(ReadLine());

            //line not needed...next line does everything!!  p.Computer(val1, val2);

            total = p.Computer(val2, val1);

            Console.WriteLine($"The total amount is {total}");

            ReadKey();

        }

        public int Computer(int fVal, int sVal)
        {
            int complete = fVal * sVal;
            return complete;
        }


    }
}
