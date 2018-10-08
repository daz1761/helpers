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
        //public ActionResult Index()
        //{
        //    SampleDBContext db = new SampleDBContext();
        //    List<SelectListItem> selectListItems = new List<SelectListItem>();

        //    foreach(Department department in db.Departments)
        //    {
        //        SelectListItem selectListItem = new SelectListItem
        //        {
        //            Text = department.Name,
        //            Value = department.Id.ToString(),
        //            Selected = department.IsSelected.HasValue ? department.IsSelected.Value : false // false is 0 with Bit T-SQL data type
        //        };
        //        selectListItems.Add(selectListItem);
        //    }

        //    ViewBag.Departments = selectListItems; // ViewBag is dynamic
        //    return View();
        //}

        public ActionResult Index()
        {
            Company company = new Company("Pragim");
            var departments = new SelectList(company.Departments, "Id", "Name"); // make a <select> list where data VALUE is ID and data name is NAME

            ViewBag.Departments = departments;
            ViewBag.CompanyName = company.CompanyName; // ViewBag is a dynamic expression and we access it ViewBag["CompanyName"]

            return View();
        }

        public ActionResult Index1()
        {
            Company company = new Company("Daz");
            return View(company);
        }
    }
}