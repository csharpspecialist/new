using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp2
{
   public abstract class Hero
    {

        public abstract string Justice();      

    }
    
    class Marvel : Hero
    {
        public int payment = 20;
        private int equation = 5;

        public override string Justice()
        {
            string muscle = "power";
            return muscle;
        }

        private int Hulk()
        {
            equation += payment;
            return equation;

        }

        public int Scheme()
        {
            return Hulk();
        }



    
    }




}
