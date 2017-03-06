using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MethWOutputParam
{
    class Program
    {                


        static void Main(string[] args)
        {

            Program p = new Program();
            int first, second;           
           
            InputMethod(out first, out second);
            Console.WriteLine($"After InputMethod first is {first}" +
                 $" \n and second is {second}");
       
            ReadKey();
        }

        private static void InputMethod(out int one, out int two)
        {
            string s1, s2;

            Console.WriteLine("Enter first integer");
            s1 = ReadLine();
            Console.WriteLine("Enter Second Integer");

            s2 = ReadLine();
            one = Convert.ToInt32(s1);
            two = Convert.ToInt32(s2);

        }
        

    }
}
