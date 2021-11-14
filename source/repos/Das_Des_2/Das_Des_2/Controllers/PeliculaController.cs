using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Das_Des_2.Models.PeliculaViewModel;
using Das_Des_2.Models.Peli;

namespace Das_Des_2.Controllers
{
    public class PeliculaController : Controller
    {

        // GET: Pelicula
        public ActionResult Index()
        {
            if(TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"].ToString();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            List<SelectListItem> lstGender = new List<SelectListItem>();

            using (var db = new CinePlusEntities())
            {
                lstGender = (from d in db.Gender
                             select new SelectListItem
                             {
                                 Value = d.idGender.ToString(),
                                 Text = d.nameGender
                             }).ToList();

            }

            ViewBag.GenderList = lstGender;            
            return View();
        }
        [HttpPost]
        public ActionResult Create(PeliculaViewModel model, string GenderList)
        {
            var RutaSitio = Server.MapPath("~/");
            var NameFile = System.IO.Path.Combine(RutaSitio + "/upluad/" + model.File.FileName);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.File.SaveAs(NameFile);

            using(var db = new CinePlusEntities())
            {
                Movie oMmovie = new Movie();

                oMmovie.idMovie = 1;
                oMmovie.nameMovie = model.NameMovie;
                oMmovie.descriptionMovie = model.DescriptionMovie;
                oMmovie.genderMovie = int.Parse(GenderList);
                oMmovie.directorMovie = model.DirectorMovie;
                oMmovie.imgMovie = NameFile.ToString();

                db.Movie.Add(oMmovie);
                db.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ShowPelicula()
        {
            return View();
        }
    }
}