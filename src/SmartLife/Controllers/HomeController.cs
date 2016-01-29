using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SmartLife.Models;

namespace SmartLife.Controllers
{
    public class HomeController : Controller
    {
        private IRootObject _root;

        public HomeController(IRootObject root)
        {
            _root = root;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MainView()
        {
            return View(_root);
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
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
