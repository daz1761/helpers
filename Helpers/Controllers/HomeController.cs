using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers.Models;

namespace Helpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SampleDBContext db = new SampleDBContext();
            ViewBag.Departments = new SelectList(db.Departments, "Id", "Name");

            return View();
        }
    }
}