using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.Models;
using TISklep.ViewModels;

namespace TISklep.Controllers
{
    public class FilmsController : Controller
    {
        MoviesContext db;
        IWebHostEnvironment hostEnvironment;

        public FilmsController(MoviesContext db, IWebHostEnvironment hostEnvironment)
        {
            this.db = db;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult ListaFilmow(string nazwaKategorii)
        {
            KategoriaViewModel vm = new KategoriaViewModel();

            var kategoria = db.Categories.Include("Movies").Where(k => k.Name == nazwaKategorii).Single();
            var filmy = kategoria.Movies.ToList();

            vm.FilmyKategorii = filmy;
            vm.Kategoria = kategoria;
            vm.FilmyTop3Najnowsze = db.Movies.OrderByDescending(f => f.DataDodania).Take(3);

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
            obj.Film.DataDodania = DateTime.Now;

            var posterPath = Path.Combine(hostEnvironment.WebRootPath, "content");
            var posterName = Guid.NewGuid() + "_" + obj.Plakat.FileName;

            var filePath = Path.Combine(posterPath, posterName);
            obj.Plakat.CopyTo(new FileStream(filePath, FileMode.Create));

            obj.Film.Plakat = posterName;

            db.Movies.Add(obj.Film);
            db.SaveChanges();

            return RedirectToAction("WszystkieFilmy");
        }

        [HttpGet]
        public IActionResult EdytujFilm(int id)
        {
            var kategoria = db.Categories.Find(db.Movies.Find(id).CategoryId);
            var film = db.Movies.Where(f => f.MovieId == id).FirstOrDefault();

            return View(film);
        }

        [HttpPost]
        public IActionResult EdytujFilm(Movie film)
        {
            var edytowany = db.Movies.Where(f => f.MovieId == film.MovieId).FirstOrDefault();
            edytowany.Title = film.Title;
            edytowany.Director = film.Director;
            edytowany.Description = film.Description;
            edytowany.Price = film.Price;
            edytowany.DataDodania = film.DataDodania;

            db.SaveChanges();


            return RedirectToAction("Szczegoly", new { idFilmu = film.MovieId});
        }

        [HttpPost]
        public IActionResult Szukaj(string fraza)
        {
            var filmy = from f in db.Movies select f;

            filmy = filmy.Where(f => f.Title.ToLower().Contains(fraza.ToLower()));

            ViewBag.szukanie = fraza;

            return View(filmy.ToList());
        }
    }
}
