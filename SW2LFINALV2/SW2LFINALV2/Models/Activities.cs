using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW2LFINALV2.Models
{
    public class Activities
    {
        [Key]
        public int Acitvity_ID { get; set; }
        public string Activity_Description { get; set; }
        public string Other_Acitvity_Details { get; set; }
    }
}