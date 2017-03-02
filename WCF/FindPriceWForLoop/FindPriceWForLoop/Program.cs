using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FindPriceWForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int[] validVals = { 189, 543, 166, 111, 122, 133, };

            double [] prices = { 26.3, 14.2, 99.5, 79.3, 224.9, 33.88 };

            double itemPrice = 0;

            bool isValidItem = false;

            int itemOrdered;

            Console.WriteLine("Please enter an Item");

            itemOrdered = Convert.ToInt32(ReadLine());

            while (x < validVals.Length && itemOrdered != validVals[x])
            { 
                ++x;
                if(x != validVals.Length)
                {
                    isValidItem = true;
                    itemPrice = prices[x];

                }

            }


            //for (int x = 0; x < validVals.Length; x++)
            //{
            //    if(itemOrdered == validVals[x])
            //    {
            //        isValidItem = true;
            //        itemPrice = prices[x];
            //        x = validVals.Length;
            //        /* adding line 34 above breaks us out
            //         * of the loop when a match is found */
            //    }
            //}

            if (isValidItem)
                Console.WriteLine($"Price is {itemPrice}");
            else
                Console.WriteLine("Sorry Item not found!!! Sucka!!!");

        }
    }
}
