using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValPrac7
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            int sum;
            int realSecondNum;
            int realFirstNum;
            Console.WriteLine("Enter the first integer to multiply");
            string val1 = Console.ReadLine();
            int.TryParse(val1, out realFirstNum);

            Console.WriteLine("Enter the first second # to multiply");
            string val2 = Console.ReadLine();
            int.TryParse(val1, out realSecondNum);

            sum = p.Multiplier(realFirstNum,realSecondNum);

            Console.WriteLine($"The total amount is {sum}");

            Console.WriteLine("Would you like to find the sum of 2 different #'s?? \n " +
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
            int total = value1;
            return total;
        }

   
    }
}
