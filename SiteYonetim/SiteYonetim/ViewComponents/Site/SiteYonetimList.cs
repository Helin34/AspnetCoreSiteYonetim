using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteYonetim.ViewComponents.Site
{
    public class SiteYonetimList:ViewComponent
    {
        SiteManager sm = new SiteManager(new EfSiteRepository());
        public IViewComponentResult Invoke()
        {
            var values = sm.GetSiteListByBilgi(1);
            return View(values);
        }
    }
}
