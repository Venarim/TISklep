using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;

namespace TISklep.Controllers
{
    public class HomeController : Controller
    {
        MoviesContext db;

        public HomeController(MoviesContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var kategorie = db.Categories.ToList();
            return View(kategorie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }
    }
}
