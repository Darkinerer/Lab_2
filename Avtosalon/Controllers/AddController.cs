using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklad.Models;

namespace Sklad.Controllers
{
    public class AddController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Add
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Avto car)
        {
            if (car.Name == null || car.Count == 0 || car.Price == 0 )
            {
                Response.Write("<script>window.alert('Заповніть всі поля!');</script>");
                return View();
            }
            else
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("../home/");
            }
        }
    }
}