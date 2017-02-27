using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PracticingWhiles
{
    class Program
    {
        static void Main(string[] args)
        {

            int idNum;
            //string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            WriteLine("Enter A valid ID Number");

            idNum = Convert.ToInt32(ReadLine());

            while(idNum < LOW || idNum > HIGH)
            {
                WriteLine($"The Id number you entered, {idNum} is Invalid \n Id Numbers must be between {LOW} and {HIGH} ");
                WriteLine("Enter an Id number:");

                idNum = Convert.ToInt32(ReadLine());                
            }

            WriteLine($"The Id Number you entered, {idNum} is valid");
            ReadLine();


        }
    }
}
