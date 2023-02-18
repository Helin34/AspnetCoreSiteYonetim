using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteYonetim.Controllers
{
    public class RegisterController : Controller
    {
        BilgiManager bm = new BilgiManager(new EfBilgiRepository());


        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }





        [HttpPost]
        public IActionResult Index(Bilgi p)
        {
            BilgiValidator bv = new BilgiValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.EvSahibiName = "Ev sahibi";
                p.EvSahibiMail = "evsahibi@gmail.com";
                bm.BilgiAdd(p);

                return RedirectToAction("Index", "Site");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
    }
}

