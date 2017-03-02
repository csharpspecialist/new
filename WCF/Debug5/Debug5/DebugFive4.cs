// How much money will you have
// after 30 days if you get a penny on the
// first day and it doubles every day?
using System;
using static System.Console;
class DebugFive4
{
   public void Quattro()
   {
      const double LIMIT = 1000000.00;
      const double START = 0.01;
      
      double total;
      int howMany;
      int count;

      Write("How many days do you think ");
      WriteLine("it will take you to reach");
      Write("{0} starting with {1}",
         LIMIT.ToString("C"), START.ToString("C"));
      WriteLine("and doubling it every day?");
     
      howMany = Convert.ToInt32(ReadLine());
      count = 0;
      total = START;

      while(total == LIMIT)
      {
         total = total * 2;
         count = count + 1; 
      }
        if (howMany >= count)
            WriteLine("Your guess was too high.");
        else if (howMany <= count)
            WriteLine("Your guess was too low.");
        else
            WriteLine("Your guess was correct.");


      WriteLine($"It takes {count} days to reach {LIMIT.ToString("C")}");
      WriteLine("when you double {0} every day",
         START.ToString("C"));

        ReadKey();
   }
}

