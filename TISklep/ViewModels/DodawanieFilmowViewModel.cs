﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.Models;

namespace TISklep.ViewModels
{
    public class DodawanieFilmowViewModel
    {
        public Movie Film { get; set; }
        public List<Category> Kategorie { get; set; }
    }
}
