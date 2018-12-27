using SW2LFINALV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SW2LFINALV2.Controllers
{
    public class HomeController : Controller
    {
        ModelContext db = new ModelContext();
        public ActionResult Index()
        {
            Activities activities = new Activities();
            activities.Acitvity_ID = 1;
            activities.Activity_Description = "This is activity 1";
            Reservation reservation = new Reservation();
            reservation.Reserve_ID = 1;
            reservation.Reserve_Status = true;
            reservation.Reserve_Duration = 5;
            Restaurant restaurant = new Restaurant();
            restaurant.Restaurant_ID = 1;
            restaurant.Restuarant_Location = "Mazzeh";
            Users user = new Users();
            user.User_ID = 1;
            user.First_Name = "Bassel";
            user.Last_Name = "Aboujeib";
            db.Users.Add(user);
            db.Reservation.Add(reservation);
            db.Restaurant.Add(restaurant);
            db.Activities.Add(activities);
            db.SaveChanges();
            return View();
        }
    }
}