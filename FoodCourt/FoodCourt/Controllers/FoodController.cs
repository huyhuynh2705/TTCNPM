﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodCourt.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Detail(string searching)
        {
            
            return View();
        }
    }
}