using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Neg;
using Model.Entity;
using WebFacturaMvc.Models;
using System.Net;
using System.Data.Entity;

namespace WebFacturaMvc.Controllers
{
    public class ClienteController : Controller
    {
        FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities();

        ClienteNeg objClienteNeg;
        public ClienteController()
        {
            objClienteNeg = new ClienteNeg();
        }
        // GET: Cliente
        public ActionResult Index()
        {
            //List<Cliente> lista = objClienteNeg.findAll();
            //var lista = objClienteNeg.findAll();
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                return View(db.cliente.ToList());
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            mensajeInicioRegistrar();

            return View();
        }
        [HttpPost]
        public ActionResult Create(cliente objCliente)
        {
            mensajeInicioRegistrar();
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                cliente cli = new cliente();
                db.cliente.Add(objCliente);
                db.SaveChanges();
            }
            //objClienteNeg.create(objCliente);
            //MensajeErrorRegistrar(objCliente);
            ViewBag.MensajeExito = "Cliente [" + objCliente.nombre + " " + objCliente.apPaterno + "] fue Registrado en el Sistema";
            //ModelState.Clear();
            return View("Create");
        }

        //mensaje de error
        public void MensajeErrorRegistrar(Cliente objCliente)
        {

            switch (objCliente.Estado)
            {
                //case 10://campo codigo vacio
                //    ViewBag.MensajeError = "Ingrese Código del Cliente";
                //    break;
                //case 1://error campo cadigo
                //    ViewBag.MensajeError = "No se permiten mas de 5 caracteres en al campo Codigo";
                //    break;
                case 1000://campo nombre vacio
                    ViewBag.MensajeError = "Error DNI, ha ingresado letras";
                    break;
                case 20://campo nombre vacio
                    ViewBag.MensajeError = "Ingrese Nombre del Cliente";
                    break;

                case 2://error de nombre
                    ViewBag.MensajeError = "No se permiten mas de 30 caracteres en el campo Nombre";
                    break;

                case 30://campo Apellido Paterno vacio
                    ViewBag.MensajeError = "Ingrese Apellido Paterno del Cliente";
                    break;

                case 3://error de Apellido Paterno
                    ViewBag.MensajeError = "No se permiten mas de 30 caracteres en el campo apPaterno";
                    break;

                case 40://campo Apellido Paterno vacio
                    ViewBag.MensajeError = "Ingrese Apellido Materno del Cliente";
                    break;

                case 4://error de Apellido Paterno
                    ViewBag.MensajeError = "No se permiten mas de 30 caracteres en el campo apMaterno";
                    break;

                case 50://campo dni vacio
                    ViewBag.MensajeError = "Ingrese DNI del Cliente";
                    break;
                case 5://error de dni
                    ViewBag.MensajeError = "Ingrese un Numero de DNI válido";
                    break;
                case 60://campod direccion vacio
                    ViewBag.MensajeError = "Ingrese Dirección del Cliente";
                    break;
                case 6://error de direccion
                    ViewBag.MensajeError = "No se permiten mas de 50 caracteres en al campo Direccion";
                    break;
                case 70://campo telefono vacio
                    ViewBag.MensajeError = "Ingrese Telefóno del Cliente";
                    break;
                case 7://error de direccion
                    ViewBag.MensajeError = "ingrese un numero de Teléfono válido";
                    break;
                case 8://error de duplicidad
                    ViewBag.MensajeError = "Cliente [" + objCliente.IdCliente + "] ya esta Registrado en el Sistema";
                    break;
                case 9://error de duplicidad
                    ViewBag.MensajeError = "Numero de DNI [" + objCliente.Dni + "] ya esta asignado a un Cliente";
                    break;
                case 99://carrera registrada con exito
                    ViewBag.MensajeExito = "Cliente [" + objCliente.Nombre + " "+ objCliente.Appaterno + "] fue Registrado en el Sistema";
                    break;

            }

        }

        public void mensajeInicioRegistrar()
        {
            ViewBag.MensajeInicio = "Ingrese Datos Del Cliente y Click en Guardar";
        }


        [HttpGet]
        public ActionResult Update(long? id)
        {
            mensajeInicialActualizar();
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                cliente cl = db.cliente.Find(id);
                return View(cl);
            }  
            //Cliente objCliente = new Cliente(id);
            //objClienteNeg.find(objCliente);
        }
        [HttpPost]
        public ActionResult Update(cliente objCliente)
        {            
            mensajeInicialActualizar();
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                //if (!ModelState.IsValid)
                    //return View();
                if (objCliente == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                //cliente cli = db.cliente.Find(objCliente.IdCliente);
                //if (cli != null)
                //{
                    /*cli.nombre = objCliente.nombre;
                    cli.apPaterno = objCliente.apPaterno;
                    cli.apMaterno = objCliente.apMaterno;
                    cli.direccion = objCliente.direccion;
                    cli.dni = objCliente.dni;
                }
                */
                //db.SaveChanges();
                db.Entry(objCliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //objClienteNeg.update(objCliente);
            //MensajeErrorActualizar(objCliente);
            //return Redirect("~/Cliente/Index/");
        }

        //mensaje de error al actualizar
        public void MensajeErrorActualizar(Cliente objCliente)
        {

            switch (objCliente.Estado)
            {
                case 10://campo codigo vacio
                    ViewBag.MensajeError = "Ingrese Código del Cliente";
                    break;
                case 1://error campo cadigo
                    ViewBag.MensajeError = "No se permiten mas de 5 caracteres en al campo Codigo";
                    break;
                case 20://campo nombre vacio
                    ViewBag.MensajeError = "Ingrese Nombre del Cliente";
                    break;

                case 2://error de nombre
                    ViewBag.MensajeError = "No se permiten mas de 30 caracteres en el campo Nombre";
                    break;

                case 30://campo Apellido Paterno vacio
                    ViewBag.MensajeError = "Ingrese Apellido Paterno del Cliente";
                    break;

                case 3://error de Apellido Paterno
                    ViewBag.MensajeError = "No se permiten mas de 30 caracteres en el campo apPaterno";
                    break;

                case 40://campo Apellido Paterno vacio
                    ViewBag.MensajeError = "Ingrese Apellido Materno del Cliente";
                    break;

                case 4://error de Apellido Paterno
                    ViewBag.MensajeError = "No se permiten mas de 30 caracteres en el campo apMaterno";
                    break;

                case 50://campo dni vacio
                    ViewBag.MensajeError = "Ingrese DNI del Cliente";
                    break;
                case 5://error de dni
                    ViewBag.MensajeError = "Ingrese un DNI Válido";
                    break;
                case 60://campod direccion vacio
                    ViewBag.MensajeError = "Ingrese Dirección del Cliente";
                    break;
                case 6://error de direccion
                    ViewBag.MensajeError = "No se permiten mas de 50 caracteres en al campo Direccion";
                    break;
                case 70://campo telefono vacio
                    ViewBag.MensajeError = "Ingrese Telefóno del Cliente";
                    break;
                case 7://error de telefono
                    ViewBag.MensajeError = "No se permiten mas de 30 caracteres en al campo Teléfono";
                    break;
                case 9://error de duplicidad
                    ViewBag.MensajeError = "Numero de DNI [" + objCliente.Dni + "] ya esta asignado a un Cliente";
                    break;

                case 99://carrera registrada con exito
                    ViewBag.MensajeExito = "Datos del Cliente [" + objCliente.IdCliente + "] Fueron actualizados";
                    break;

            }

        }
        //mensjae inicial actualizar
        public void mensajeInicialActualizar()
        {
            ViewBag.MensajeInicialActualizar = "Formulario para Actualizar Datos del Cliente";
        }

        [HttpGet]
        public ActionResult Delete(long? id)
        {
            mensajeInicialEliminar();
            //cliente objCliente = new cliente(id);
            //objClienteNeg.find(objCliente);
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                cliente cli = db.cliente.Find(id);
                return View(cli);
            }
        }
        
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(long? id)
        {

            mensajeInicialEliminar();
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                cliente cli = db.cliente.Find(id);
                db.cliente.Remove(cli);
                db.SaveChanges();

                ViewBag.MensajeExito = "Cliente [" + cli.apPaterno + " " + cli.apMaterno + ", " + cli.nombre + "] Fue Eliminado!!!";
                return RedirectToAction("Index");

            }
            /*
            mensajeInicialEliminar();
            Cliente objCliente = new Cliente(id);
            //objClienteNeg.delete(objCliente);
            mostrarMensajeEliminar(objCliente);
            return RedirectToAction("Index");
            //return Redirect("~/Cliente/Index/");
            */
        }

        [HttpGet]
        public ActionResult Eliminar(long id)
        {
            mensajeInicialEliminar();
            //cliente objCliente = new cliente(id);
            //objClienteNeg.find(objCliente);
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                cliente cli = db.cliente.Find(id);
                return View(cli);
            }
        }

        [HttpPost]
        public ActionResult Eliminar(cliente objCliente)
        {
            mensajeInicialEliminar();
            using (FerreteriaDiplomadoEntities db = new FerreteriaDiplomadoEntities())
            {
                cliente cli = db.cliente.Find(objCliente.idCliente);
                db.SaveChanges();

                ViewBag.MensajeExito = "Cliente [" + objCliente.apPaterno + " " + objCliente.apMaterno + ", " + objCliente.nombre + "] Fue Eliminado!!!";
                return RedirectToAction("Index");

            }
                //objClienteNeg.delete(objCliente);
                //mostrarMensajeEliminar(objCliente);
            //Cliente objCLiente2 = new Cliente();
            //return View(objCLiente2);
            //return RedirectToAction("Index");
        }

        //mensaje de error al eliminar
        private void mostrarMensajeEliminar(Cliente objCliente)
        {

            switch (objCliente.Estado)
            {
                case 1: //ERROR DE EXISTENCIA
                    ViewBag.MensajeError = "Cliente [" + objCliente.IdCliente + "] No Esta Registrado en el Sistema ";
                    break;

                case 33://CLIENTE NO EXISTE
                    ViewBag.MensajeError = "El Cliente: ["+objCliente.Appaterno+" "+objCliente.Apmaterno+", "+objCliente.Nombre+" ]Ya Fue Eliminado";
                    break;
                case 34:
                    ViewBag.MensajeError = "No se Puede Eliminar al Cliente [" + objCliente.Appaterno + " " + objCliente.Apmaterno + ", " + objCliente.Nombre + "] Tiene Ventas Registrados en el Sistema!!!";
                    break;
                case 99: //EXITO
                    ViewBag.MensajeExito = "Cliente [" + objCliente.Appaterno + " " + objCliente.Apmaterno + ", " + objCliente.Nombre + "] Fue Eliminado!!!";
                    break;

                default:
                    ViewBag.MensajeError = "===???===";
                    break;
            }
        }
        public void mensajeInicialEliminar()
        {
            ViewBag.MensajeInicialEliminar = "Formulario de Eliminacion";
        }

        public ActionResult Find(long id)
        {
            Cliente objCliente = new Cliente(id);
            objClienteNeg.find(objCliente);
            //objClienteNeg.find2(objCliente);
            return View(objCliente);
        }

        [HttpGet]
        public ActionResult BuscarClientes()
        {
            List<Cliente> lista = objClienteNeg.findAll();
            return View(lista);
        }
        [HttpPost]
        public ActionResult BuscarClientes(string txtnombre, string txtappaterno, string txtdni, long txtcliente = -1)
        {
             
            if (txtnombre == "") 
            {
                txtnombre = "-1";                
            }
            if (txtappaterno == "") {
                txtappaterno = "-1";
            }
            if(txtdni == "")
            {
                txtdni = "-1";
            }
            Cliente objCliente = new Cliente();
            objCliente.Nombre = txtnombre;
            objCliente.IdCliente = txtcliente;
            objCliente.Appaterno = txtappaterno;
            objCliente.Dni = txtdni;         
            
            List<Cliente> cliente = objClienteNeg.findAllClientes(objCliente);
            if (cliente.Count == 0)
                cliente = objClienteNeg.findAll();
            return View(cliente);
        }       
    }
}