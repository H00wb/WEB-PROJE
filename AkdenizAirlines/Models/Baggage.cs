using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkdenizAirlines.Models
{
    public class Baggage
    {
        public int BaggageId { get; set; }
        public int weight { get; set; }
        public float volume { get; set; }
        public string baggage_type { get; set; }


    }
}