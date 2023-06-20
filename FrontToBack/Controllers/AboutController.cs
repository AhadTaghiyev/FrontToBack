using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Context;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly FrontToBackDbContext _context;

        public AboutController(FrontToBackDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            About? about = _context.Abouts.FirstOrDefault();

            return View(about);
        }

  
    }
}

