﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class ReservationsController : Controller
    {
        public IActionResult Index()
        {
            DB db = DB.Restore();
            ViewBag.bookings = db.booking;
            ViewBag.Title = "All Reservations";
            //ViewBag.bookings = db.GetBookingByName("Conor");  
            //String dt = "20-03-2020";
            //ViewBag.bookings = db.GetBookingByDate(dt);


            return View();

        }

        public IActionResult Date(String dt)
        {
            ViewBag.Title = string.Format("All Reservations on {0}", dt);
            DB db = DB.Restore();
            List<Booking> bookingDate = db.GetBookingByDate(dt);
            if(bookingDate.Count == 0)
            {
                ViewBag.Message = "The are no bookings for the date " + dt + " please try another date";
                return View("NotFound");
            }

            ViewBag.Bookings = bookingDate;

            return View();
        }

        public IActionResult BookingInfo(int Id)
        {
            ViewBag.Title = string.Format("Details of Booking Number {0}", Id);
            DB db = DB.Restore();
            Booking bookingInfo = db.GetBookingById(Id);
              if (bookingInfo == null)
               {
                   ViewBag.Message = "The are no bookings for the id " + Id + " please try another date";
                   return View("NotFound");
               }

            

            return View(bookingInfo);
        }

    }
}