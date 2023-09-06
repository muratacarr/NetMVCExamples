using Example01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example01.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> products;

        public HomeController()
        {
            products = new List<Product>
            {
                new Product(){Name = "Iphone 14", Price= 75000},
                new Product(){Name = "Samsung S23",Price=40000 }

            };
        }
        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}