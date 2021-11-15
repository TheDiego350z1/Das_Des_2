using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Das_Des_2.Models.PeliculaViewModel;
using Das_Des_2.Models.Peli;
using Das_Des_2.Models.PeliculaTableViewModel;

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
            var FileName = System.IO.Path.Combine("/upluad/" + model.File.FileName);

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
                oMmovie.imgMovie = FileName.ToString();
                db.Movie.Add(oMmovie);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ShowPelicula()
        {
            List<PeliculaTableViewModel> lst = new List<PeliculaTableViewModel>();
            using (var db = new CinePlusEntities())
            {
                lst = (from d in db.Movie
                       join b in db.Gender
                       on d.genderMovie equals b.idGender
                       select new PeliculaTableViewModel
                       {
                           IdMovie = d.idMovie,
                           NameMovie = d.nameMovie,
                           DescriptionMovie = d.descriptionMovie,
                           DirectorMovie = d.directorMovie,
                           ImgMovie = d.imgMovie,
                           GeneroMovie = b.nameGender
                       }).ToList(); 
            }
            return View(lst);
        }
        [HttpGet]
        public ActionResult ShowTablePelicula ()
        {
            List<PeliculaTableViewModel> lst = new List<PeliculaTableViewModel>();
            using (var db = new CinePlusEntities())
            {
                lst = (from d in db.Movie
                       join b in db.Gender
                       on d.genderMovie equals b.idGender
                       select new PeliculaTableViewModel
                       {
                           IdMovie = d.idMovie,
                           NameMovie = d.nameMovie,
                           DescriptionMovie = d.descriptionMovie,
                           DirectorMovie = d.directorMovie,
                           ImgMovie = d.imgMovie,
                           GeneroMovie = b.nameGender
                       }).ToList();
            }
            return View(lst);
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            using (var db = new CinePlusEntities())
            {
                var oMovie = db.Movie.Find(Id);
                db.Movie.Remove(oMovie);
                db.SaveChanges();
            }
            return Content("1");
        }
        public ActionResult Edit(int Id)
        {
            List<SelectListItem> lstGender = new List<SelectListItem>();
            EditPeliculaViewModel model = new EditPeliculaViewModel();

            using (var db = new CinePlusEntities())
            {
                lstGender = (from d in db.Gender
                             select new SelectListItem
                             {
                                 Value = d.idGender.ToString(),
                                 Text = d.nameGender
                             }).ToList();

                var oMovie = db.Movie.Find(Id);
                model.IdMovie = oMovie.idMovie;
                model.NameMovie = oMovie.nameMovie;
                model.DescriptionMovie = oMovie.descriptionMovie;
                model.DirectorMovie = oMovie.directorMovie;
                model.ImageUrl = oMovie.imgMovie;
            }
            ViewBag.GenderList = lstGender;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditPeliculaViewModel model, string GenderList)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new CinePlusEntities())
            {
                var oMovie = db.Movie.Find(model.IdMovie);
                oMovie.nameMovie = model.NameMovie;
                oMovie.descriptionMovie = model.DescriptionMovie;
                oMovie.directorMovie = model.DirectorMovie;
                oMovie.genderMovie = int.Parse(GenderList);

                if (model.File != null)
                {
                    var RutaSitio = Server.MapPath("~/");
                    var NameFile = System.IO.Path.Combine(RutaSitio + "/upluad/" + model.File.FileName);
                    var FileName = System.IO.Path.Combine("/upluad/" + model.File.FileName);
                    oMovie.imgMovie = FileName; 

                    model.File.SaveAs(NameFile);

                }
                oMovie.imgMovie = model.ImageUrl;

                db.Entry(oMovie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/User/ShowUser"));
        }
    }
}