using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PriceListClassApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int item;
            try
            {
                Console.WriteLine("Enter an Item # >>");
                item = Convert.ToInt16(ReadLine());

                PriceList.DisplayPrice(item);
            }


            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Just Hanging at the end of the prog!!");
            ReadLine();
        }
    }


    class Tax
    {
        private static double[] taxRate = { 0.06, 0.07 };
        private static double CUTOFF = 20.00;

        public static double DetTaxRate(double price)
        {
            int subscript;
            double rate;

            if (price <= CUTOFF)
                subscript = 0;
            else
                subscript = 2; //dont do this..mistake on purpose

            rate = taxRate[subscript];
            return rate;
        }              

    }

    class PriceList
    {
        private static double[] price = { 15.99, 27.88, 25.55, 45.22 };

        public static void DisplayPrice(int item)
        {
            double tax;
            double total;
            double pr;

            pr = price[item];
            tax = pr * Tax.DetTaxRate(pr);
            total = pr + tax;
            Console.WriteLine("The total price is " + total.ToString());
        }

    }
}
