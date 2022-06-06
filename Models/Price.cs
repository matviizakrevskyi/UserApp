using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Models
{
    class Price_
    {
        public int ID { get; set; }
        private int idFlight;
        public int IDFlight { get { return idFlight; } set { idFlight = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private int price;
        public int Price { get { return price; } set { price = value; } }

        public Price_() { }
        public Price_(int idFlight, string name, int price)
        {
            IDFlight = idFlight;
            Name = name;
            Price = price;
        }
    }
}
