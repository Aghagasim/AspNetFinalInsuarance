using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jotex.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Awards()
        {
            return View();
        }
        public IActionResult PricingPlan()
        {
            return View();
        }
        public IActionResult Testimonials()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
    }
}