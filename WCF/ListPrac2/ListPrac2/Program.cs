using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrac2
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.ShowCars();




        }

        public List<Cars> GetAutoList()
        {

            return new List<Cars>
                {
                        new Cars
                {
                    CarID = 1,
                    Make = "Charger",
                    Model = "Dodge"

                },
                        new Cars
                {

                     CarID = 1,
                     Make = "Impala",
                     Model = "Chevy"

                },

                    new Cars
                    {

                  CarID = 1, Make = "Corvette"
                    , Model = "Chevy"

                    },

                           new Cars
                    {

                        CarID= 4,
                        Make = "Dodge",
                 Model = "Ram 1500"

                    },
                };

        }

        public class Cars
        {
            public int CarID { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }

        }

        public Cars ShowCars()
        {
            List<Cars> car = new List<Cars>();
            var mobiles = from e in GetAutoList()
                          orderby e.CarID
                          select e;

            return car;
            //{
            //    new Cars;
            //}
        }
    }
}
 