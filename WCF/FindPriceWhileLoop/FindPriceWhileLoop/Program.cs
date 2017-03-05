using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FindPriceWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

           //cannot get this to work correctly!!!!
            //int x = 0;
            int[] validVals = { 189, 543, 166, 111, 122, 133, };

            double[] prices = { 26.3, 14.2, 99.5, 79.3, 224.9, 33.88 };

            double itemPrice = 0;

            bool isValidItem = false;

            int itemOrdered;

            Console.WriteLine("Please enter an Item #");

            itemOrdered = Convert.ToInt32(ReadLine());

            int x = 0;

            while (x < validVals.Length && itemOrdered == validVals[x]) 
            {

                ++x;
                if(x != validVals.Length)
                {
                    isValidItem = true;
                    itemPrice = prices[x];

                }

                if(isValidItem)
                {
                    WriteLine($"item {itemOrdered} sells for {itemPrice.ToString("C")}");
                }
                else
                {
                    WriteLine($"That Item # that you entered, {itemOrdered} does not exist ");

                }

                ReadKey();
            }

            Console.WriteLine("No way");
            ReadKey();




        }
    }
}
