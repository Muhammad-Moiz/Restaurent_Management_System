using IPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPT.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            IndexModel model = new IndexModel();
            model.id = 123;
            model.name = "Saqlain";

            return View(model);
        }


    }
}