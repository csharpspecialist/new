using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugEx4_1
{
    class Debug4_4
    {

        double sales, commission;       
        const int LOWSALES = 1000;
        const int MEDSALES = 5000;
        const int HIGHSALES = 10000;
        const double LOWPCT = 0.05;
        const double MEDPCT = 0.02;
        const int BONUS1 = 1000;
        const int BONUS2 = 1500;

            public void Smoothie()
            { 

            WriteLine("What was the sales amount? ");                    
            sales = Convert.ToDouble(ReadLine());

            commission = LOWPCT* sales;
            if(sales <= LOWSALES)
              commission += (sales - LOWSALES) * MEDPCT;

            else if(sales >= MEDSALES)
              commission += BONUS1;

            else if(sales >= HIGHSALES)
              commission += BONUS2; 

            WriteLine($"Sales: {sales.ToString("C")} \n Commission: { commission.ToString("C")}");
            }

        }


}




