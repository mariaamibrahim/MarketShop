using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperMarket_Core_Project.Controllers
{
    public class GourmetController : Controller
    {
        public IActionResult Gourmet()
        {
            return View();
        }
    }
}