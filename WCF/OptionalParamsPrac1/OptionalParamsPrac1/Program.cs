using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OptionalParamsPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int finalNum;
            int total;
            Console.WriteLine("Enter the first number to multiply");

            int mystNum1 = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter the second number to multiply");

            int mystNum2 = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter the optional number to multiply");
            string tempNum = ReadLine();

            //int mystNum3 = Convert.ToInt16(ReadLine());

            int mystNum3;

            while (!int.TryParse(tempNum, out mystNum3))
                {

                }

            p.Mutlplier(mystNum1, mystNum2, mystNum3);

            finalNum = p.Mutlplier(mystNum1, mystNum2,mystNum3);
            Console.WriteLine($"The sum of the 2 or 3 numbers you entered is {finalNum}");
            ReadLine();

            p.Adder(mystNum3, mystNum1, mystNum2);

            total = p.Adder(mystNum1, mystNum2, mystNum3);

            Console.WriteLine($"The sum of the 2 or 3 numbers you entered is {total}");
            ReadLine();


        }

        public int Mutlplier(int multNum1, int multNum2, int therom = 5) //therom is optional!!!
        {
            int sum = multNum1 * multNum2 * therom;
            return sum;
        }

        public int Adder(int addNum1, int addNum2, int addNum3 = 10)//addNum3 is optional
        {
            int complete = addNum1 + addNum2 + addNum3;

            return complete;
        }


    }
}
