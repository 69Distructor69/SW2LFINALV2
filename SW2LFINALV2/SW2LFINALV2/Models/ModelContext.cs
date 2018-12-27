using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SW2LFINALV2.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=ModelContext")
        {

        }
        public virtual DbSet<Users> Users {get; set;}
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<GPS> GPS { get; set; }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }

    }
}