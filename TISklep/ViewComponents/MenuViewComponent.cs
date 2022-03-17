using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;

namespace TISklep.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        MoviesContext db;

        public MenuViewComponent(MoviesContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var kategorie = db.Categories.ToList();

            return await Task.FromResult((IViewComponentResult)View("_Menu", kategorie));
        }
    }
}
