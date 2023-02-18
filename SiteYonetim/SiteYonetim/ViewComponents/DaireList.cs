using Microsoft.AspNetCore.Mvc;
using SiteYonetim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteYonetim.ViewComponents
{
    public class DaireList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var dairevalues = new List<UserDaire>
            {
                new UserDaire
                {
                    ID=1,
                    BlokAdi="A"
                },
                new UserDaire
                {
                    ID=2,
                    BlokAdi="B"
                },
                new UserDaire
                {
                    ID=3,
                    BlokAdi="C"
                },

            };

            return View(dairevalues);
        }
    }
}
