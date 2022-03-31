using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.ViewModels;

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
            KategoriaViewModel vm = new KategoriaViewModel();

            var kategoria = db.Categories.Include("Movies").Where(k => k.Name == nazwaKategorii).Single();
            var filmy = kategoria.Movies.ToList();

            vm.FilmyKategorii = filmy;
            vm.Kategoria = kategoria;
            vm.FilmyTop3Najnowsze = db.Movies.OrderByDescending(f => f.ProductionDate).Take(3);

            return View(vm);
        }

        public IActionResult Szczegoly(int idFilmu)
        {
            var kategoria = db.Categories.Find(db.Movies.Find(idFilmu).CategoryId);
            var film = db.Movies.Find(idFilmu);

            return View(film);
        }

        public IActionResult WszystkieFilmy(int idFilmu)
        {
            var film = db.Movies.ToList();           
            return View(film);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DodajFilm()
        {
            var model = new DodawanieFilmowViewModel();
            model.Kategorie = db.Categories.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult DodajFilm(DodawanieFilmowViewModel obj)
        {
            obj.Film.ProductionDate = DateTime.Now;
            db.Movies.Add(obj.Film);
            db.SaveChanges();

            return RedirectToAction("WszystkieFilmy");
        }
    }
}
