using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication56.Models;

namespace WebApplication56.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var equip = db.Equipment
            //    .where(e => e.blah == something)
            //    .select(e => new { e.name });
            var items = new SelectList(
                new List<string>() { "KS", "TX", "MO", "CO", "NE", "OK" });
            ViewBag.Items = items;
            return View();
        }
        [HttpPost]
        public ActionResult Index(My_DTO data)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}