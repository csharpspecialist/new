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
      double howMany;
      double count;

      
      WriteLine("How many days do you think \n it will take you to reach");
      WriteLine($"{LIMIT.ToString()} starting with {START.ToString()} and doubling it every day?");
      
     
      howMany = Convert.ToDouble(ReadLine());
      count = 0;
      total = START; 

      while(total < LIMIT) //changed from == to <
      {
         total = total * 2; 
         ++count; 
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

