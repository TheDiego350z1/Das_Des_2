using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Das_Des_2.Models;
using Das_Des_2.Models.UserTableViewModel;
using Das_Des_2.Models.Peli;
using Das_Des_2.Models.UserViewModel;

namespace Das_Des_2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowUser()
        {
            List<UserTableViewModel> lst = null;
            using (var db = new CinePlusEntities())
            {

                lst = (from d in db.User
                      select new UserTableViewModel
                      {
                          idUser = d.idUser,
                          nameUser = d.nameUser,
                          mailUser = d.mailUser
                      }).ToList();
            }

            return View(lst);
        }
        //Crear nuevo usuario
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new CinePlusEntities())
            {
                User oUser = new User();

                oUser.idUser = 1;
                oUser.nameUser = model.NameUser;
                oUser.mailUser = model.MailUser;
                oUser.passwordUser = model.PasswordUser;

                db.User.Add(oUser);

                db.SaveChanges();

            }

            return Redirect(Url.Content("~/User/"));

        }
        //Editar Usuario
        public ActionResult Edit(int Id)
        {
            EditUserViewModel model = new EditUserViewModel();

            using (var db = new CinePlusEntities())
            {
                var oUser = db.User.Find(Id);

                model.NameUser = oUser.nameUser;
                model.MailUser = oUser.mailUser;
                model.idUser = oUser.idUser;

            }
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new CinePlusEntities())
            {
                var oUser = db.User.Find(model.idUser);
                oUser.nameUser = model.NameUser;
                oUser.mailUser = model.MailUser;

                if(model.PasswordUser != null && model.PasswordUser.Trim() != "")
                {
                    oUser.passwordUser = model.PasswordUser;
                }

                db.Entry(oUser).State = System.Data.Entity.EntityState.Modified; 
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/User/ShowUser"));
        }
        //Edilinar Usuario
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            using (var db = new CinePlusEntities())
            {
                var oUser = db.User.Find(Id);
                db.User.Remove(oUser);
                db.SaveChanges();
            }

            return Content("1");

        }
    }
}