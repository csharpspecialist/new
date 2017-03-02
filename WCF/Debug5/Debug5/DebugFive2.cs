// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must re-enter the number
// The program displays the correct price
using System;
using static System.Console;

namespace Debug5
{ 
class DebugFive2
    {
       public void Dos()
       {
        
        
          const int ITEM209 = 209;
          const int ITEM312 = 312;
          const int ITEM414 = 414;
          const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
          double price;
          int stockNum;
          Write("Please enter the stock number of the item you want ");
            stockNum = Convert.ToInt16(ReadLine());
          while(stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414)
          {
             WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Convert.ToInt16(ReadLine());
                //stockNum = ReadLine();
          }
          if(stockNum == ITEM209)
             price = PRICE209;
          else
             if(stockNum == ITEM312)
                price = PRICE312;
             else
                price = PRICE414;
          WriteLine($"The price for item # {stockNum} is {price.ToString("C")}");
            ReadKey();
       }

    }
}
