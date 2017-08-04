using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ListPrac3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customr c1 = new Customr();

            c1.CustID = 1;
            c1.FName = "Tony";
            c1.LName = "Stark";
            c1.Salary = 3500;

            Customr c2 = new Customr()
            {
                CustID = 2,
                FName = "Pepper",
                LName = "Potts",
                Salary = 3300
            };

            Customr c3 = new Customr()
            {
                CustID = 3,
                FName = "Benn",
                LName = "Grimm",
                Salary = 2900
            };

            Customr c4 = new Customr()
            {
                CustID = 4,
                FName = "Susan",
                LName = "Storm",
                Salary = 4100
            };

            List<Customr> cust = new List<Customr>(4);
            cust.Add(c1);
            cust.Add(c2);
            cust.Add(c3);


            //Works fine also!!!!
            //foreach (Customr item in cust)
            //{
            //    item.PrintHeros();
            //}

            //works fine!!!!
            foreach (Customr c in cust)
            {
                Console.WriteLine($"here {c.FName}");
            }

            //Does not work as it is right now!!!!
            //for (int i = 0; i < cust.Count; i++)
            //{
            //    Customr c = cust[i];
            //    Console.WriteLine(c.CustID.ToString(),c.FName);
            //}

            ReadLine();
        }
    }



    class Customr
    {
        public int CustID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double Salary { get; set; }

        public void PrintHeros()
        {

            Console.WriteLine($"Hero ID,{CustID}, {FName},  {LName} {Salary}");
        }
    }

}
