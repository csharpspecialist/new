using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TaxRate
{
    class Program
    {
        //public double taxPercent = .08;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sale amount");
            double saleAmount = Convert.ToDouble( ReadLine());

            CalcTax(saleAmount);
        }

        public static void CalcTax(double saleAmount)
        {

            double taxPercent = .08;
            double tax;
           
            tax = saleAmount * taxPercent;

            Console.WriteLine($"Your taxes on the sale amount of {saleAmount.ToString("C")} are {tax.ToString("C")} \n " + 
                $"based on a tax % of {taxPercent.ToString("C")}");

            ReadLine();
        }
    }       
    
}
