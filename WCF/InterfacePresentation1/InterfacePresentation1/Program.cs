using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePresentation1
{
    //All of this codeis inside of the program Class!!!!
    class Program
    {
        /*dont create anything outside of the 
         * program class or u will be sorry!!!!!
        */

        public interface ITransactions
        {
            // interface members
            void showTransaction();
            double getAmount();
        }
        //the class Transaction must be inside of class program
        //or this will not work!!!!!!
        public class Transaction : ITransactions
        {
            private string tCode;
            private string date;
            private double amount;
            //public Transaction()
            //{
            //    tCode = " ";
            //    date = " ";
            //    amount = 0.0;
            //}

            //constructor that takes 3 args
            public Transaction(string c, string d, double a)
            {
                tCode = c;
                date = d;
                amount = a;
            }

            public double getAmount()
            {
                return amount;
            }

            public void showTransaction()
            {
                Console.WriteLine("Transaction: {0}", tCode);
                Console.WriteLine("Date: {0}", date);
                Console.WriteLine("Amount: {0}", getAmount());
            }
        }//the class tester must be inside of class program
        //or this will not work!!!!!!
        class Tester
        {
            static void Main(string[] args)
            {
                Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
                Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
                // Transaction t3 = new Transaction();


                // t3.showTransaction();

                Console.WriteLine("");




                 t1.showTransaction();
                t2.showTransaction();
                Console.ReadKey();
            }




        }

    }
}
