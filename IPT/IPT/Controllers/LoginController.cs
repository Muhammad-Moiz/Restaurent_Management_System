﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPT.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult login()
        {
            

            return View();
        }
        [HttpPost] 
        public ActionResult check()
        {
            
   
            return View("Index");
        }
    }
}