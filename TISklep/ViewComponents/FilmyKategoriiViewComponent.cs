using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;

namespace TISklep.ViewComponents
{
    public class FilmyKategoriiViewComponent : ViewComponent
    {
        MoviesContext db;

        public FilmyKategoriiViewComponent(MoviesContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nazwaKategorii)
        {
            var kategoria = db.Categories.Include("Movies").Where(k => k.Name == nazwaKategorii).Single();
            var filmy = kategoria.Movies.ToList();

            return await Task.FromResult((IViewComponentResult)View("_FilmyKategorii", filmy));
        }

    }
}
