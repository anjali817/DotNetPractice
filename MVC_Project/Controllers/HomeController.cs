using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            ViewBag.abc = "Hii Anjali Rai";
            ViewBag.test = 1234;
            ViewBag.test1 = 23.5f;
            ViewBag.test2 = DateTime.Now;
            ViewBag.test3 = "Welcome To Noida";
            ViewBag.List = new List<string>()
                { 
                "India",
                "Pakistan",
                "USA",
                "Banglore",
            };
         
            ViewData["abc1"] = "View Data Value";
            ViewData["test1"] = 8888;
            ViewData["test2"] = 11.7f;
            ViewData["test3"] = 34.98;
            ViewData["test4"] = DateTime.Now;
            ViewData["test5"] = "I LOVE INDIA";
            ViewData["List Data"]=new List<string>()
            {
                "INDIA",
                    "PAKISTAN",
                    "USA",
                    "GUJRAT",
            };
            TempData["abc"] = "Hi This is Temp";
            TempData["abc1"] = 7777;
            TempData["abc2"] = 76.6f;
            TempData["abc3"] = DateTime.Now;
            
            Session["abc"] = "Hi This is Session";
            Session["abc1"] = 7337;
            Session["abc2"] = 86.6f;
            Session["abc3"] = DateTime.Now;

            return View();
        }

        public ActionResult About()
        {
            ClassModel obj = new ClassModel();
            obj.id = 123;
            obj.name = "Anjali";

            return View(obj);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}