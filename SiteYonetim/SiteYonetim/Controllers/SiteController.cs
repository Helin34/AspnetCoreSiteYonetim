using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteYonetim.Controllers
{
    public class SiteController : Controller
    {
        SiteManager sm = new SiteManager(new EfSiteRepository());
        public IActionResult Index()
        {
            var values = sm.GetSiteWithCategory();
            return View(values);
        }
        public IActionResult SiteReadAll(int id)
        {
            ViewBag.i = id;
            var values = sm.GetSiteByID(id);
            return View(values);

        }
    }
}
