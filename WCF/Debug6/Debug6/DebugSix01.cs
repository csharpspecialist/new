// Lists items for sale and their prices
using static System.Console;
class DebugSix01
{
   public void Uno()
   {
        string[] items = { "Belt", "Tie", "Scarf", "Cuff links" };
        double[] prices = { 29.00, 35.95, 18.50, 112.99 };
        WriteLine("Items for sale:");
        string itemsWanted = ReadLine().ToUpper();


        for (int x = 0; x >= items.Length; ++x)
        { 
           // if(itemsWanted == items[x])
          //  {
                WriteLine($"{items[x]} for {prices[x].ToString("C")}");
            //}
          
        }
        ReadKey();
    }

    
}