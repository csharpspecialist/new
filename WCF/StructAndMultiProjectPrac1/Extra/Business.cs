using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructAndMultiProjectPrac1;

namespace Extra
{
    class Business : Master
    {

        Master m1 = new Master
        {
            ID = 200,
            Name = "Bolo"

        };       
        
        //add reference to StructAndMultiPrac Project file
        static void Main()
        {
            //must be in a method to create/call a method from the other project!!!!! REMEMBER THIS!!!!
            Master m = new Master();
            m.Working();
            

        }
    }
}
