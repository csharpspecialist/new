using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArrayPrac3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = { 22, 25, 77, 13, 51 };

            for(int d = 0; d < nums.Length; d++)
            {
                Console.WriteLine(nums[d]);

                sum += nums[d];
            }
            Console.WriteLine($"The value of the array is {sum}");

            Console.ReadKey();
        }




    }
}
