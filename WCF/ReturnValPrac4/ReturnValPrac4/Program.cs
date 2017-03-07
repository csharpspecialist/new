using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ReturnValPrac4
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            int sum;
            
            Console.WriteLine("Enter the first integer to multiply");

            int int1 = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter the 2nd integer to multiply");

            int int2 = Convert.ToInt16(ReadLine());

            sum = p.Multiplier(int1, int2);

            Console.WriteLine($"The total amount is {sum}");

            Console.WriteLine("Would you like to find the sum of 2 different #'s?? \n "+ 
                "Y for Yes or N for No");

            string ans = Console.ReadLine().ToUpper();
            if (ans == "Y")
            {
               Main();
            }
            else
            {
                Console.WriteLine("Have a nice day and thanks for using our program");
            }
        }


        public int Multiplier(int value1, int value2)
        {
            int total = value1 * value2;
            return total;
        }
    }
}
