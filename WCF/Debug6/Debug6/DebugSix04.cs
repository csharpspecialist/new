// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04
{
   public void Quattro()
   {
      const int QUIT = 999;
      int[] numbers = {10, 142, 88, 75, 90, 150};
      int x;
      int num;
      double average;
      double total = 0; 
         
        
      Console.Write("Please enter a number or " +
         QUIT + " to quit...");
   
      num = Convert.ToInt16(ReadLine());
      while(num < numbers.Length && num != QUIT)
      {
 	  numbers[x] = num;
          total += numbers[x];
          ++x;
          Write("Please enter a number or " +
             QUIT + " to quit...");
          
            num = Convert.ToInt16(ReadLine());
        }
      WriteLine("The numbers are:");
      for(int y = 0; y < x; ++x)
        { 
          Console.Write("{0,6}", numbers[y]);
        
        average = total / y;
        }
        WriteLine();
      WriteLine($"The average is {average}");
  }
}
