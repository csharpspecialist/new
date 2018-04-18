using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrPrac1
{

   public abstract class Customer
    {
        public abstract void Print();
        public abstract void Show();

    }


   public class Program : Customer
    {

        public override void Print()
        {
            Console.WriteLine("Today is a Ok");
        }

        public override void Show()
        {
            Console.WriteLine("I am Working over here!!!");
        }


        static void Main(string[] args)
        {
            Program p1 = new Program();
            Customer c = new Program();

            p1.Print();
            c.Show();
            Console.ReadLine();
        }
    }
}
