using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = new int[] { 1, 2, 3, 5 ,9, 66,14 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
                        
            int total = p.dude(arr);

            Console.WriteLine(sum);
            Console.WriteLine(total);
            Console.ReadLine();                       
            
        }


        public int dude (int [] smash)
        {

            int sumation = smash.Sum();

            return (sumation);

        }



    }
}
