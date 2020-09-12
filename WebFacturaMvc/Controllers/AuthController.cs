using Model.Entity.EfModels;
using System;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebFacturaMvc.Models;
using WebFacturaMvc.DataClass;

namespace WebFacturaMvc.Controllers
{
    public class AuthController : Controller
    {
        Models.FerreteriaDiplomadoEntities repo;

        
        // GET: Auth
        public FerreContext _context { get; set; }
        public AuthController()
        {
            this.repo = new Models.FerreteriaDiplomadoEntities();
            this._context = new FerreContext();

        }
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult CloseSession() {

            Session["IsLog"] = null;

            return View();
        }

        [HttpPost]
        public ActionResult GetLog(LogCred logdata) {


            try
            {
                Usuarios userLog = repo.Usuarios.Where(x => x.Nombre == logdata.User && x.Contrasena == logdata.Password).FirstOrDefault();
                //var userLog = this._context.Usuarios.Where(x => x.Nombre == logdata.User && x.Contrasena == logdata.Password);

                if (userLog != null)
                {
                    Session["IsLog"] = "true";
                    Session["username"] = logdata.User;
                    Session["id"] = userLog.UsuarioID;

                    //  var valorsession = bool.Parse(Session["IsLog"].ToString());

                    return Json(new { redirectToUrl = Url.Action("Index", "Inicio"), Result = true });
                }

                else {

                    return Json(new { Result = false, Mensaje = "Usuario o Contraseña Incorrectas" });
                }


            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(Models.Usuarios usuarios)
        {
                       
                this.repo.Usuarios.Add(usuarios);
                this.repo.SaveChanges();

                return RedirectToAction("Index");
           
           
        }


    }

    




}