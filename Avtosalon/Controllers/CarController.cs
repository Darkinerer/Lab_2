using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklad.Models;

namespace Sklad.Controllers
{
    public class CarController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Car
        public ActionResult Car(int id)
        {
            ViewBag.ProductId = id;
            Avto car = context.Cars.Find(id);
            if (car != null)
            {
                return View(car);
            }
            return View("Car");
        }
    }
}