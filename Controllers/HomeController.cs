using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BigPandaBakery.Models;

namespace BigPandaBakery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            ViewData["Message"] = "The Menu page.";

            return View();
        }

        public IActionResult Order()
        {
            ViewData["Message"] = "The Order Online page.";

            return View();
        }

        public IActionResult ProductBread(int? id)
        {
            ViewData["Message"] = "The Product Bread page.";
            return View();
        }

        public IActionResult ProductCake(int? id)
        {
            ViewData["Message"] = "The Product Cake page.";
            //System.Web.HttpContext.Current.Session["ShowCart"] = "show";
            return View();
        }

        public IActionResult ProductTea(int? id)
        {
            ViewData["Message"] = "The Product Tea page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
