using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Data;
using Jotex.Models;
using Jotex.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jotex.Controllers
{
    public class ServicesController : Controller
    {
        private readonly JotexDbContext _context;
        public ServicesController(JotexDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _context.Services.ToListAsync());
        }

        public async Task<IActionResult> Details()
        {
            ServiceViewModel model = new ServiceViewModel
            {
                Services = await _context.Services.ToListAsync()
            };
            return View(model);
        }
    }
}