//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Dao.EntityContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        public int ClienteID { get; set; }
        public string Descripcion { get; set; }
        public string Representante { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Fax { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Nota { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Rnc { get; set; }
        public string Precio { get; set; }
        public string Fichas { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public string Vendedor { get; set; }
        public Nullable<int> LimiteCredito { get; set; }
    }
}