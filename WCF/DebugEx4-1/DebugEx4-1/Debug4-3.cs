using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugEx4_1
{
    class Debug4_3
    {
        public void Tuition()
        {
     

            int credits, year;
           //unnecessary variable    string inputString;
            double tuition = 100;
                const int CREDITHOUR = 200;
                const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 150.00;
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;
          WriteLine("How many credits? ");        
            credits = Convert.ToInt32(ReadLine());
          WriteLine("Year in school? ");        
            year = Convert.ToInt32(ReadLine());

            if (credits > 12 && credits < 19)
                tuition += tuition * CREDITHOUR;
            else if (credits > LOWCREDITS)

                tuition = HOURFEE * credits;
            else if (credits == HIGHCREDITS)
                tuition = FLAT;
            else
                tuition = FLAT + (credits - HIGHCREDITS) * RATE;
          if(year<SENIORYEAR)
             tuition = tuition - (tuition* DISCOUNT);
          WriteLine($"For year {year}, with {credits} credit hours");
          WriteLine("Tuition is {0}", tuition.ToString("C"));

                ReadKey();

        }
    }
}
