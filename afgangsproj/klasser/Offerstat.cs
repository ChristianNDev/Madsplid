using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afgangsprojekt.pattens
{
    class Offerstat
    {

        private static int ID = ID;
        private int myId = 0;

        public int MyId
        {
            get { return myId; }
        }

        public Offerstat() 
        {
            ID++;
            this.myId = ID;
        }

    }
}
