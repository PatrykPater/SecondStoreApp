﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using SecondStoreApp.DAL;

namespace SecondStoreApp.Controllers
{
    public class CourseController : Controller
    {
        private StoreDbContext db = new StoreDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string categoryName)
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult CategoryMenu(string id)
        {
            var categories = db.Categories.ToList();
            return PartialView("_CategoryMenu", categories);
        }
    }
}