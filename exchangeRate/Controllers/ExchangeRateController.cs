﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exchangeRate.Controllers
{
    public class ExchangeRateController : Controller
    {
        // GET: ExchangeRate
        public ActionResult Index()
        {
            return View();
        }
    }
}