using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW2LFINALV2.Models
{
    public class Restaurant
    {
        [Key]
        public int Restaurant_ID { get; set; }
        public string Restuarant_Location { get; set; }
        public string Restaurant_Price { get; set; }
    }
}