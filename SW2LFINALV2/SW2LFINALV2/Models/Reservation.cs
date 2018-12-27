using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW2LFINALV2.Models
{
    public class Reservation
    {
        [Key]
        public int Reserve_ID { get; set; }
        public bool Reserve_Status { get; set; }
        public int Reserve_Duration { get; set; }
    }
}