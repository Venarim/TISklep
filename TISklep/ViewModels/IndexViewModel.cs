using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.Models;

namespace TISklep.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Movie> FilmyTop3Najdluzsze { get; set; }
    }
}
