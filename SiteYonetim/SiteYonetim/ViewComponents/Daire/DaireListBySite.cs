using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteYonetim.ViewComponents.Daire
{
    public class DaireListBySite : ViewComponent
    {
        DaireManager dm = new DaireManager(new EfDaireRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = dm.GetList(id);
            return View(values);

        }
    }
}