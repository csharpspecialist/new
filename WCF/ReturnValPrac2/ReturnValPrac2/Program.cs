using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ReturnValPrac2
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            int total;

            Console.WriteLine("Enter the first # to multiply");

            int num1 = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter the first # to multiply");

            int num2 = Convert.ToInt16(ReadLine());

            p.Multiply(num1, num2);

            total = p.Multiply(num1, num2);

            Console.WriteLine(total);

            Console.WriteLine(p.Multiply(num1,num1));

            ReadKey();
        }

        public int Multiply(int place1, int place2)
        {
            int ans = place1 * place2;

            return ans;

        }



    }

}
