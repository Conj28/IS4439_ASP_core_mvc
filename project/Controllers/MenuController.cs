﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Menu";
            return View();
        }
    }
}