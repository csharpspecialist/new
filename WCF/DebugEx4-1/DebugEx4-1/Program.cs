using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace DebugEx4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug4_3 four = new Debug4_3();
            Debug4_4 plus = new Debug4_4();

            plus.Smoothie();
            four.Tuition();


        }
        
            public void Hotdog()
        {

            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            String wantChili, wantCheese;
            double price;
            Write("Do you want chili on your dog? ");
            wantChili = ReadLine().ToUpper();
            Write("Do you want cheese on your dog? ");
            wantCheese = ReadLine().ToUpper();
            if (wantChili == "Y" && wantCheese == "Y")
                price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
            else if (wantChili == "Y")
                price = BASIC_DOG_PRICE + CHILI_PRICE;
            else if (wantCheese == "Y")
                price = BASIC_DOG_PRICE + CHEESE_PRICE;
            else
                price = BASIC_DOG_PRICE;
            WriteLine($"Your total is {price.ToString("C")}");



        }






    }
    
}
