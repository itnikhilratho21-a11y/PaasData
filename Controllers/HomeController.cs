using PaasData.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace PaasData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["name"] = "Niksky tech Pvt Ltd";
            ViewBag.Email = "nikskytech@gmail.com";
            TempData["address"] = "Tejaji Nagar near bridge indore";


            return View();

        }
        public ActionResult Index2()
        {
            return View();

        }
        
        public ActionResult Index3()
        {
            int number = 100000;

            return View("index3",number);

        }
        public ActionResult Index4()
        {
            Product p = new Product() { Id = 10, Name = "Pent", Price = 599 };
            return View(p);
        }
        public ActionResult Index5()
        {
            int number1 = 2303;
            return View("Index5",number1);
        } 
        public ActionResult Index6()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id =1, Name ="Shirt",Price=123},
                new Product(){Id =2,Name="N Shirt",Price=211},
                new Product(){Id =3,Name="R Name Shirt",Price=403}
            };
            return View(products);
            
        }
    }
}