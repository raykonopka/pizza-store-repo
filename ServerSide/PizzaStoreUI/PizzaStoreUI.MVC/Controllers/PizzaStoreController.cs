using PizzaStoreUI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreUI.MVC.Controllers
{
    public class PizzaStoreController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            var model = new PizzaModel();
            return View(model);
        }

        public ActionResult OrderHistory()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}