﻿ using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.Title = "Home";
            return View();
        }

       
    }
}
