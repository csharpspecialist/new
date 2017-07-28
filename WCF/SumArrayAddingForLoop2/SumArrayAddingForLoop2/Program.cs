using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayAddingForLoop2
{
    class Program
    {

        static void Main()
        {
            Program p = new Program();
            //this app counts 5 times then stops
            int[] arr = new int[505];//must start with 505 here or blows up!!!
            int sum = 500;
            Console.WriteLine("Your starting balance is  $500");
            for (int y = 500; y < 505; y++) //500 & 505 or blows up!!!
            {

                Console.WriteLine("Enter a Deposit amount");
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


           // Console.WriteLine(sum);
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

