using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayAddingForLoop1
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();

            int[] arr = new int[5];
            int sum = 0;
            for (int y = 0; y < 5; y++)
            {

                Console.WriteLine("Enter a number");
                arr[y] = int.Parse(Console.ReadLine());
                sum += arr[y];
                Console.WriteLine($"The current balance of your account is currently {sum}");

            }

            //for (int i = 0; i < arr.Length; i++)
            //{        // I moved the code in line 28+29 into the loop starting on line 17
            //    sum += arr[i];
            //    Console.WriteLine($"The current balance of your account is currently {sum}");
            //}

            foreach (int k in arr)
            {
                sum += k;
                
            }

           
            Console.WriteLine(sum);
            p.BeginAgain();
            //Console.ReadLine();

            //use this for each to display the output of the array at the end
            foreach (int k in arr)
            {
                sum += k;
               // Console.WriteLine(k);
            }

            //Console.Read();


        }

        public void BeginAgain()
        {
            Console.WriteLine("Would you like to start the program over?? \n " +
          "Y for Yes or N for No");

            string ans = Console.ReadLine().ToUpper();
            if (ans == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Have a nice day and thanks for using our program");
            }
        }



    }
}
