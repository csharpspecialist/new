using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrac1
{


    enum worth
    {
        North, West, East, South
    };

        
    class Martian
    {
        public void SpaceGhost()
        {
            WriteLine(worth.West);
        }
        
        public void ArrayLoop()
        {

            string[] toons = { "Batman", "Wonder Woman", "Green Lantern", "Iron man", "Spidey" };

            for (int i = 0; i < toons.Length; i++)
            {
                WriteLine(toons[i]);
            }
          
            ReadKey();
        }


        public void BankAppLoop()
        {
            double bankBal = 1000; ;
            const double INT_RATE = 0.04;
            //string inputString;
            char response;

            WriteLine("Would U like to see your balance");

            response = Convert.ToChar(ReadLine().ToUpper());

            while (response == 'Y')
            {
                WriteLine($"Your bank balance is {bankBal} ");
                bankBal.ToString("C");
                bankBal = bankBal + (bankBal * INT_RATE);
                WriteLine("Would you like to see next year's balance");
                response = Convert.ToChar(ReadLine().ToUpper());



            }
            WriteLine("Have a nice day");










        }

    }
}
