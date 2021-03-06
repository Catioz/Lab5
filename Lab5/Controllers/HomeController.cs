﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       

        public ActionResult Save(string text)
        {
            string file = Server.MapPath(@"~\App_Data\base.txt");

            if (!string.IsNullOrWhiteSpace(text))
            {
                System.IO.File.AppendAllText(file, text + '\n');
            }

            return View("Index");
        }

        public ActionResult About()
        {
            string file = Server.MapPath(@"~\App_Data\base.txt");
            string[] lines = System.IO.File.ReadAllLines(file);
            ViewBag.Lines = lines;
            return View();
        }
    }
}
