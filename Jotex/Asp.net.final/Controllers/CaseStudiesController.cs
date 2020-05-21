using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jotex.Controllers
{
    public class CaseStudiesController : Controller
    {
        private readonly JotexDbContext _context;
        public CaseStudiesController(JotexDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.CaseStudies.ToListAsync());
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}