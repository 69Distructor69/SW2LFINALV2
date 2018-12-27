using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW2LFINALV2.Models
{
    public class Experience
    {
        [Key]
        public int Experience_ID { get; set; }
        public string Experience_Location { get; set; }
        public string Experience_Price { get; set; }

    }
}