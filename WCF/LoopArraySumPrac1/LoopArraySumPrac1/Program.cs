using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArraySumPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] whole = new[]  { 1, 10, 25, 33, 20 };

            for (int i = 0; i < whole.Length; i++)
            {

                //  Console.WriteLine(whole[i]);
                total += (whole[i]);
               // Console.WriteLine(total);
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
