using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Context;
using FrontToBack.ViewModels;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using FrontToBack.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly FrontToBackDbContext _context;

        public HomeController(FrontToBackDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //hecer bu birinci idi
            //IEnumerable<Slide> slides = _context.Slides.ToList();
            //return View(slides);
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Slides = _context.Slides.ToList();
            homeViewModel.About = _context.Abouts.FirstOrDefault();
            return View(homeViewModel);
        }

        

        //public IActionResult Create()
        //{
        //    Slide slide = new Slide()
        //    {
        //        Title = "Ilkinin esger gedisi",
        //        Description = "Oturmusduxda gul kimi lazim idi mene 1 il 6ay",
        //        Link = "https://mod.gov.az/"
        //    };
        //    Slide slide2 = new Slide()
        //    {
        //        Title = "Code academiyanin Hecerle imtahani",
        //        Description = "Telebkarliq 5 min vermisem orgetmelisizdee vhdsgs dsd shd shd shgd ",
        //        Link = "https://mod.gov.az/"
        //    };
        //    Slide slide3 = new Slide()
        //    {
        //        Title = "Nicatin Evlilik teklifi",
        //        Description = "OAllah haqqi qaqa mecbur qaldim o qeder deyindi",
        //        Link = "https://mod.gov.az/"
        //    };
        //    _context.Slides.Add(slide);
        //    _context.Slides.Add(slide2);
        //    _context.Slides.Add(slide3);

        //    _context.SaveChanges();
        //    return Json("Ok");
        //}
    }
}

