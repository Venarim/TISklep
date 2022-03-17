using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;

namespace TISklep.Controllers
{
    public class FilmsController : Controller
    {
        MoviesContext db;

        public FilmsController(MoviesContext db)
        {
            this.db = db;
        }

        public IActionResult ListaFilmow(string nazwaKategorii)
        {
            var kategoria = db.Categories.Include("Movies").Where(k => k.Name == nazwaKategorii).Single();
            var filmy = kategoria.Movies.ToList();

            return View(filmy);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
