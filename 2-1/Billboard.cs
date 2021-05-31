using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1
{
     public class Billboard
    {
        public string adress;
        public bool rented;
        public DateTime rentFrom, rentTo;

        public Billboard(string adress,bool rented)
        {
            
            this.adress = adress;
            this.rented = rented;
        }
        public Billboard(string adress, bool rented, DateTime rentFrom,DateTime rentTo)
        {      
            this.adress = adress;
            this.rented = rented;
            this.rentFrom = rentFrom;
            this.rentTo = rentTo;

        }
    }
}
