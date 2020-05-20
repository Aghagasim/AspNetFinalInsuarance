using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jotex.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}