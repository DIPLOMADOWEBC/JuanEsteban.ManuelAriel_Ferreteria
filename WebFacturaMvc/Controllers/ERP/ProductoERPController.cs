using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebFacturaMvc.Models;

namespace WebFacturaMvc.Controllers.ERP
{
    public class ProductoERPController : Controller
    {
        // GET: ProductoERP
        public ActionResult Index(string txtnombre)
        {
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {

                List<Inventario> prod = new List<Inventario>();
                var inv = db.Inventario.ToList();
                prod = db.Inventario.Where(x => x.Codigo.Contains(txtnombre) ||
                x.CodigoFabricante.Contains(txtnombre) || x.Descripcion.Contains(txtnombre)
                || x.Categoria.Contains(txtnombre) || x.Tipo.Contains(txtnombre)).ToList();

                var invLim = prod.ToList();
                if (txtnombre != "" && txtnombre != null)
                    return View(invLim.ToList());
                else
                    return View(inv.ToList());
            }
        }
        public ActionResult Detalle(int? id)
        {
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                if (id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                Inventario inv = db.Inventario.Find(id);
                if (inv == null)
                    return HttpNotFound();
                return View(inv);
            }
        }
        [HttpGet]
        public ActionResult Delete(long? id)
        {
            //cliente objCliente = new cliente(id);
            //objClienteNeg.find(objCliente);
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                Inventario inv = db.Inventario.Find(id);
                return View(inv);
            }
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long? id)
        {
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                Inventario inv = db.Inventario.Find(id);
                db.Inventario.Remove(inv);
                db.SaveChanges();

                ViewBag.MensajeExito = "Producto [" + inv.Codigo + " " + inv.Descripcion + "] Fue Eliminado!!!";
                return RedirectToAction("Index");

            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MensajeInicio = "Ingrese Datos Del Producto y Click en Guardar";
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                List<CategoriasProductos> data = db.CategoriasProductos.ToList();
                SelectList lista = new SelectList(data, "CategoriaID", "Descripcion");
                ViewBag.ListaCategorias = lista;

                var listTip = new SelectList(new[]
                {
                    new { ID = "0", Name = "Fisico" },
                    new { ID = "1", Name = "Servicio" },
                    new { ID = "2", Name = "Otro" },
                },
                "ID", "Name", 1);
                ViewBag.ListaTipo = listTip;
                //mensajeInicioRegistrar();
                return View();
            }
        }
        [HttpPost]
        public ActionResult Create(Inventario objInv)
        {

            ViewBag.MensajeInicio = "Ingrese Datos Del Producto y Click en Guardar";
            //mensajeInicioRegistrar();
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                List<CategoriasProductos> data = db.CategoriasProductos.ToList();
                SelectList lista = new SelectList(data, "CategoriaID", "Descripcion");
                ViewBag.ListaCategorias = lista;
                var listTip = new SelectList(new[]
                {
                    new { ID = "0", Name = "Fisico" },
                    new { ID = "1", Name = "Servicio" },
                    new { ID = "2", Name = "Otro" },
                },
                "ID", "Name", 1);
                ViewBag.ListaTipo = listTip;

                CategoriasProductos cat = new CategoriasProductos();
                if (objInv.CategoriaID != 0 && objInv.CategoriaID != null)
                {
                    cat = db.CategoriasProductos.Find(objInv.CategoriaID);
                    if (cat != null)
                        objInv.Categoria = cat.Descripcion;
                }

                if (!ModelState.IsValid)
                    return View();

                decimal itbis = 18;
                objInv.Precio1_Itbis = (objInv.Precio1 + (objInv.Precio1 * itbis) / 100);
                objInv.Tipo = listTip.Skip(int.Parse(objInv.Tipo)).First().Text;

                Inventario cli = new Inventario();
                db.Inventario.Add(objInv);
                db.SaveChanges();
            }
            //objClienteNeg.create(objCliente);
            //MensajeErrorRegistrar(objCliente);
            ViewBag.MensajeExito = "Inventario [" + objInv.Codigo + " " + objInv.Descripcion + "] fue Registrado en el Sistema";
            //ModelState.Clear();
            return View("Create");
        }
        [HttpGet]
        public ActionResult Update(long? id)
        {
            ViewBag.MensajeInicio = "Ingrese Datos Del Producto y Click en Guardar";

            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                List<CategoriasProductos> data = db.CategoriasProductos.ToList();
                SelectList lista = new SelectList(data, "CategoriaID", "Descripcion");
                ViewBag.ListaCategorias = lista;

                var listTip = new SelectList(new[]
                {
                    new { ID = "0", Name = "Fisico" },
                    new { ID = "1", Name = "Servicio" },
                    new { ID = "2", Name = "Otro" },
                },
                "ID", "Name", 1);
                ViewBag.ListaTipo = listTip;


                if (id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                Inventario inv = db.Inventario.Find(id);
                if (inv == null)
                    return HttpNotFound();
                switch(inv.Tipo)
                {
                    case "Fisico":
                        inv.Tipo = "0";
                        break;
                    case "Servicio":
                        inv.Tipo = "1";
                        break;
                    case "Otro":
                        inv.Tipo = "2";
                        break;
                }
                return View(inv);
            }
        }
        [HttpPost]
        public ActionResult Update(Inventario objInv)
        {
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                if (objInv == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                List<CategoriasProductos> data = db.CategoriasProductos.ToList();
                SelectList lista = new SelectList(data, "CategoriaID", "Descripcion");
                ViewBag.ListaCategorias = lista;

                var listTip = new SelectList(new[]
                {
                    new { ID = "0", Name = "Fisico" },
                    new { ID = "1", Name = "Servicio" },
                    new { ID = "2", Name = "Otro" },
                },
                "ID", "Name", 1);
                ViewBag.ListaTipo = listTip;

                CategoriasProductos cat = new CategoriasProductos();
                if (objInv.CategoriaID != 0 && objInv.CategoriaID != null)
                {
                    cat = db.CategoriasProductos.Find(objInv.CategoriaID);
                    if (cat != null)
                        objInv.Categoria = cat.Descripcion;
                }

                if (!ModelState.IsValid)
                    return View();

                decimal itbis = 18;
                objInv.Precio1_Itbis = (objInv.Precio1 + (objInv.Precio1 * itbis) / 100);

                switch (objInv.Tipo)
                {
                    case "Fisico":
                        objInv.Tipo = "0";
                        break;
                    case "Servicio":
                        objInv.Tipo = "1";
                        break;
                    case "Otro":
                        objInv.Tipo = "2";
                        break;
                }
                objInv.Tipo = listTip.Skip(int.Parse(objInv.Tipo)).First().Text;

                db.Entry(objInv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}