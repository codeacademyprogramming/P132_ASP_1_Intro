using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstAsp.Controllers
{
  
    public class HomeController:Controller
    {
        //public ContentResult Index()
        //{
        //    ContentResult cr = new ContentResult();
        //    cr.Content = "<h1>Salam, Dunya!</h1>";

        //    return cr;
        //}

        public ViewResult Index()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "Index";


            return vr;
        }

        public JsonResult Student()
        {
            var obj = new { Name = "Hikmet", GroupNo = "132" };

            JsonResult jr = new JsonResult(obj);


            return jr;
        }

        public ViewResult About()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "about";

            return vr;
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ContentResult Content(int id,string name,string surname)
        {
            ContentResult cr = new ContentResult();
            cr.Content = $"Fullname: {id} -  {name} {surname}";

            return cr;
        }

        public ViewResult Faq()
        {
            return View();
        }

    }
}
