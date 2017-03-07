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
      int[] numbers = new int [20];
      int x = 0;  //needs to be assigned a value here for line 24 to work properly
      int num;
      double average = 0;
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
        
        average = total / x;
        }
        WriteLine();
      WriteLine($"The average is {average}");
  }
}
