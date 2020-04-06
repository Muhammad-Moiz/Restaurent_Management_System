using IPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPT.Controllers
{
    public class RestaurentController : Controller
    {
        // GET: Restaurent
        public ActionResult RestaurentList1()
        {

            using (FoodManagementEntities7 fd = new FoodManagementEntities7())
            {
                return View(fd.Restaurents.ToList());

            }

         }
        public ActionResult BranchList(int id)
        {

            using (FoodManagementEntities10 fd = new FoodManagementEntities10())
            {
                return View( );

            }
        
         }
    }
}