using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValPrac3
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine("Enter the first # to add");

            int num1 = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter the 2nd # to add");

            int num2 = Convert.ToInt16(ReadLine());

            p.MethodAdd(num1, num2);

        }

        public int MethodAdd(int val1, int val2)
        {

            int answ = val1 * val2;

            return answ;
        }

    }
}
