using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteYonetim.Controllers
{
    public class DaireController : Controller
    {
        DaireManager cm = new DaireManager(new EfDaireRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddDaire()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddDaire(Daire p)
        {
            //p.DaireNUMARA = ToString();
            cm.DaireAdd(p);
            //Response.Redirect("/Site/SiteReadAll/" + 1);
            return PartialView();
        }

        public PartialViewResult DaireListBySite(int id)
        {
            var values=cm.GetList(id);
            return PartialView(values);
        }
    }
}
