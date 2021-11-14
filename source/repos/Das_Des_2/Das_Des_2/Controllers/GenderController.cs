using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Das_Des_2.Models.Peli;
using Das_Des_2.Models.GenderViewModel;

namespace Das_Des_2.Controllers
{
    public class GenderController : Controller
    {
        // GET: Gender
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(GenderViewModel model)
        {
            using (var db = new CinePlusEntities())
            {
                Gender oGender = new Gender();

                oGender.idGender = 1;
                oGender.nameGender = model.nameGender;

                db.Gender.Add(oGender);
                db.SaveChanges();
                
            }
            return Redirect("Index");
        }
    }
}