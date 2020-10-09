using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuan1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new Tuan1.Models.TMDTEntities();
            var ListNews = db.Categories;

            return View(ListNews);
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