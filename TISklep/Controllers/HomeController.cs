using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.ViewModels;

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
            IndexViewModel vm = new IndexViewModel();

            vm.FilmyTop3Najdluzsze = db.Movies.OrderByDescending(f => f.DlugoscFilmu).Take(3);

            return View(vm);
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
