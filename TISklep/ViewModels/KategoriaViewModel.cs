using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.Models;

namespace TISklep.ViewModels
{
    public class KategoriaViewModel
    {
        public Category Kategoria { get; set; }
        public IEnumerable<Movie> FilmyKategorii { get; set; }
        public IEnumerable<Movie> FilmyTop3Najnowsze { get; set; }
    }
}
