using PaasData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaasData.Controllers
{
    public class ProductController : Controller
    {
       
     public ActionResult Index()
     {
            List<Product> products = new List<Product>()
            {
                new Product(){Id=1 ,Name="Jens", Price=999},
                new Product(){Id=2,Name="AmzonShirt",Price=2999},
                new Product(){Id=3,Name="JsShirt",Price=400 }

            };

            TempData["products"] = products;

            return View(products);
     }
        public ActionResult Create()
        {
            return View();

        }

        [HttpGet]
        public ActionResult Edit( int? id)
        {
            List<Product> products = (List<Product>)TempData.Peek("products");

            Product product = products.FirstOrDefault(p=>p.Id ==id);
            return View(product);
                
        }
        [HttpPost]
        public ActionResult Edit(int? id,Product updateProduct)
        {
            List<Product> products = (List<Product>)TempData.Peek("products");
            Product product = products.FirstOrDefault(p => p.Id == id);
            return View(product);

        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            List<Product> products = (List<Product>)TempData.Peek("products");
            Product product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        





    }
}