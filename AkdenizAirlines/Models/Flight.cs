using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkdenizAirlines.Models
{
    public class Flight
    {

        public int FlightId { get; set; }
        public string depart_date { get; set; }
        public string return_date { get; set; }
        public int number_of_passengers { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string classType { get; set; }




    }
}