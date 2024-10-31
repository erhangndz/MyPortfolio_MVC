﻿using MyPortfolio_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio_MVC.Controllers
{
    public class ProjectController : Controller
    {
       MyPortfolioDb6Entities db = new MyPortfolioDb6Entities();
        public ActionResult Index()
        {
            var projects = db.TblProjects.ToList();
            return View(projects);
        }
    }
}