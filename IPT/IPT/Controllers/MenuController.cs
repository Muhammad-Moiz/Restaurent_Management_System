using IPT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPT.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult GetFoodItem1()
        {
                 using(FoodManagementEntities3  fd = new FoodManagementEntities3())
            {
                return View(fd.FoodItems.ToList());

            }

        }
        public ActionResult AddFoodItem1()
        {
            return View("AddFoodItem1");
        }

        [HttpPost]
        public ActionResult AddFoodItem1(FoodItem item)
        {
            using (FoodManagementEntities3 fd = new FoodManagementEntities3())
            {

                fd.FoodItems.Add(item);
                fd.SaveChanges();
            }
            return RedirectToAction("GetFoodItem1");
        }

        public ActionResult Edit(int id)
        {
            using (FoodManagementEntities3 fd = new FoodManagementEntities3())
            {
                return View(fd.FoodItems.Where(x => x.Id == id).FirstOrDefault() );
            }
         }
        [HttpPost]
        public ActionResult Edit(int id, FoodItem item)
        {
            using (FoodManagementEntities3 fd = new FoodManagementEntities3())
            {
                fd.Entry(item).State = EntityState.Modified;
                fd.SaveChanges();
             }
            return RedirectToAction("GetFoodItem1");   
        }

        public ActionResult Delete(int id)
        {
            using (FoodManagementEntities3 fd = new FoodManagementEntities3())
            {
                FoodItem i = fd.FoodItems.Where(x => x.Id == id).FirstOrDefault();
                fd.FoodItems.Remove(i);
                fd.SaveChanges();
            }
            return RedirectToAction("GetFoodItem1");
        }

        public ActionResult OrderList1()
        {

            using (FoodManagementEntities4 fd = new FoodManagementEntities4())
            {
                return View(fd.Orders.ToList());

            }



        }

        public ActionResult PaymentList1()
        {

            using (FoodManagementEntities6 fd = new FoodManagementEntities6())
            {
                return View(fd.Payment1.ToList());

            }
             
        }
        public ActionResult AddFood()
        {


            return View();
        }

    }
}