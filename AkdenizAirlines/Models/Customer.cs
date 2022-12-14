using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkdenizAirlines.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string credit_card_number { get; set; }
        public string phone_number { get; set; }


    }
}