using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _33.Models;

namespace _33.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
        
        public ActionResult Index()
        {
            var model = db.HomeModels.FirstOrDefault(m => m.Current);

            if (model != null)
            {
                ViewBag.Message = model.Name;
            }
            else
            {
                ViewBag.Message = "No project selected.";
            }

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
