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

            WriteLine("Enter the first # to multiply");

            int num1 = Convert.ToInt16(ReadLine());

            WriteLine("Enter the second # to multiply");

            int num2 = Convert.ToInt16(ReadLine());

            p.Multiply(num1, num2);

            total = p.Multiply(num1, num2);  //this line of code makes this work

            WriteLine(total); //this works

            WriteLine(p.Multiply(num1,num1));//does not come up with right answer

            ReadKey();
        }

        public int Multiply(int place1, int place2) 
        {
            int ans = place1 * place2;

            return ans;

        }



    }

}
