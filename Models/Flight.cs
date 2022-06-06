using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Models
{
    class Flight
    {
        public int ID { get; set; }

        private int day;

        private string name, from, to, departure, arrival;

        public int Day { get { return day; } set { day = value; } }

        public string Name { get { return name; } set { name = value; } }
        public string From { get { return from; } set { from = value; } }
        public string To { get { return to; } set { to = value; } }
        public string Departure { get { return departure; } set { departure = value; } }
        public string Arrival { get { return arrival; } set { arrival = value; } }


        public Flight() { }
        public Flight(string name, string from, string to, int day, string departure, string arrival)
        {
            Name = name;
            From = from;
            To = to;
            Day = day;
            Departure = departure;
            Arrival = arrival;
        }
    }
}
