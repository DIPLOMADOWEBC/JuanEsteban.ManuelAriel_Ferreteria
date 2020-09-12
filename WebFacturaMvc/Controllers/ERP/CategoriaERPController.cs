using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebFacturaMvc.Models;

namespace WebFacturaMvc.Controllers.ERP
{
    public class CategoriaERPController : Controller
    {
        // GET: CategoriaERP
        public ActionResult Index()
        {
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                List<CategoriasProductos> cat = new List<CategoriasProductos>();
                cat = db.CategoriasProductos.ToList();

                return View(cat);
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CategoriasProductos objcate)
        {
            ViewBag.MensajeInicio = "Ingrese Datos da la Categoria y Click en Guardar";
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                if (objcate == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                if (!ModelState.IsValid)
                    return View();

                db.CategoriasProductos.Add(objcate);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult Update(long? id)
        {
            ViewBag.MensajeInicio = "Ingrese Datos da la Categoria y Click en Guardar";
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                if (id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                CategoriasProductos cat = db.CategoriasProductos.Find(id);
                if (cat == null)
                    return HttpNotFound();


                return View(cat);
            }
        }
        [HttpPost]
        public ActionResult Update(CategoriasProductos objcat)
        {

            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                db.Entry(objcat).State = EntityState.Modified;
                db.SaveChanges();
                

                if (!ModelState.IsValid)
                    return View();

                return RedirectToAction("Index");
            }
        }
        public ActionResult Detalle(long? id)
        {
            ViewBag.MensajeInicio = "Ingrese Datos da la Categoria y Click en Guardar";
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                if (id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                CategoriasProductos cat = db.CategoriasProductos.Find(id);
                if (cat == null)
                    return HttpNotFound();


                return View(cat);
            }
        }
        [HttpGet]
        public ActionResult Delete(long? id)
        {
            ViewBag.MensajeInicialEliminar = "Formulario de Eliminacion";
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                if (id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                CategoriasProductos cat = db.CategoriasProductos.Find(id);
                if (cat == null)
                    return HttpNotFound();


                return View(cat);
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long? id)
        {
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                CategoriasProductos inv = db.CategoriasProductos.Find(id);
                db.CategoriasProductos.Remove(inv);
                db.SaveChanges();

                ViewBag.MensajeExito = "Producto [" + inv.CategoriaID + " " + inv.Descripcion + "] Fue Eliminado!!!";
                return RedirectToAction("Index");

            }
        }
    }
}