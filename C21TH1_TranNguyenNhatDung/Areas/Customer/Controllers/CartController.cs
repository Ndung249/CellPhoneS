﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C21TH1_TranNguyenNhatDung.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cart()
        {

            return View();
        }
    }
}
