using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket_Core_Project.Models;

namespace SuperMarket_Core_Project.Controllers
{
    public class CRUDController : Controller
    {
        private DataContext db = new DataContext();

        [Route("Cart")]
        public IActionResult Cart()
        {
            ViewBag.Product = db.Product.ToList();
            return View();
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View("Create", new Product());
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Product Products)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(Products);
                db.SaveChanges();

            }
            return RedirectToAction("Cart");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id = 0)
        {
            db.Remove(db.Product.Find(id));
            db.SaveChanges();
            return RedirectToAction("Cart");
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id = 0)
        {
            return View("Edit", db.Product.Find(id));
        }

        [HttpPost]
        [Route("Edit/{id?}")]
        public IActionResult Edit(int id, Product Products)
        {
            db.Entry(Products).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChangesAsync();
            return RedirectToAction("Cart");
        }
    }
}