﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeWebTemplate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
		// GET: Home/Contact
		public ActionResult Contact()
		{
			return View();
		}
		// GET: Home/Blog
		public ActionResult Blog()
		{
			return View();
		}
		// GET: Home/BlogPost
		public ActionResult BlogPost()
		{
			return View();
		}
	}
}