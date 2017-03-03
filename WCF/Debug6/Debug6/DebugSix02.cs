// Program averages four numbers
using static System.Console;
class DebugSix02
{
   public void Dos()
   {
      int[] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total = 0;
      Write("\n The numbers are...");
      for(x = 0; x < numbers.Length; ++x)
         Write("{0, 6}", numbers[x]);
      WriteLine();      
      for(x = 0; x < numbers.Length; ++x)
      {//changed the line below from a = to a += in order to sum up the numbers array  so that the average in line 19 worked properly
         total += numbers[x];
      }   
      average = total / numbers.Length;
      Write($"The average is {average}");

        ReadLine();
   }
}