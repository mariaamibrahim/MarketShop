﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperMarket_Core_Project.Controllers
{
    public class OffersController : Controller
    {
        public IActionResult Offers()
        {
            return View();
        }
    }
}