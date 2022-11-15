using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstAsp.Controllers
{
   
    public class ProductController:Controller
    {

        public IActionResult Index()
        {
            List<string> products = new List<string>
            {
                "Iphone 11",
                "S20",
                "Nokia 6300"
            };

            ViewBag.Products = products;
            return View();
        } 

        public ViewResult Detail(int id,string name,decimal price)
        {
            ViewBag.Id = 55;
            ViewData["id"] = id;
            TempData["id"] = 40;


            ViewBag.Name = name;

            return View();
        }
    }
}
