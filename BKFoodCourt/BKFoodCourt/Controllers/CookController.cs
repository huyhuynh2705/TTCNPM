﻿using BKFoodCourt.Common;
using BKFoodCourt.DatabaseAccess.Dao;
using BKFoodCourt.DatabaseAccess.EF;
using BKFoodCourt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BKFoodCourt.Controllers
{
    public class CookController : Controller
    {
        // GET: Cook
        private bool check()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 2)
            {
                return false;
            }
            return true;
        }

        public ActionResult Index()
        {
            if (!check())
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult OrderList()
        {
            if (!check())
            {
                return RedirectToAction("Login", "User");
            }
            var dao = new OrderDao();
            List<DonHang> res = dao.getOrderList();
            return View(res);
        }

        public ActionResult CookInfo()
        {
            if (!check())
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
    }
}