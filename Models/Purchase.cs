using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Models
{
    class Purchase
    {
        public int ID { get; set; }
        public int IDFlight { get; set; }
        public int IDUser { get; set; }

        public Purchase() { }
        public Purchase(int iDFlight, int iDUser)
        {
            IDFlight = iDFlight;
            IDUser = iDUser;
        }
        public Purchase(int iD, int iDFlight, int iDUser)
        {
            ID = iD;
            IDFlight = iDFlight;
            IDUser = iDUser;
        }   
    }
}
