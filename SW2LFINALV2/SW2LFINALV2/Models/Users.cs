using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SW2LFINALV2.Models
{
    public class Users
    {
        [Key]
        public int User_ID { get; set; }
        public string First_Name { get; set; }
        public string  Last_Name  { get; set; }
        public string Houses { get; set; }
        public string Visited_Houses { get; set; }
        public string Vistied_Events { get; set; }
        public string Visited_Restaurants { get; set; }
        public string Reviewed { get; set; }
    }
}