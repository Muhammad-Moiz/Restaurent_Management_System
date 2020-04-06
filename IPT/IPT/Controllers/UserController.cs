using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPT.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult CustomerList()
        {
            return View();
        }
    }
}