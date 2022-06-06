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
        private int idFlight, idUser;
        public int IDFlight { get { return idFlight; } set { idFlight = value; } }
        public int IDUser { get { return idUser; } set { idUser = value; } }
    }
}
