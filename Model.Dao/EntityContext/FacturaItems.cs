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
    
    public partial class FacturaItems
    {
        public int ItemID { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public string Codigo { get; set; }
        public Nullable<int> FacturaID { get; set; }
        public Nullable<int> ProductoID { get; set; }
        public Nullable<decimal> CantAlmacen { get; set; }
        public Nullable<bool> Eliminada { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public string Cotizacion { get; set; }
        public string Expiraciones { get; set; }
        public Nullable<decimal> Itbis { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<bool> Prepado { get; set; }
        public Nullable<bool> SinImpuesto { get; set; }
        public Nullable<System.DateTime> Inicio { get; set; }
        public Nullable<System.DateTime> Fin { get; set; }
        public Nullable<decimal> Precio1 { get; set; }
        public Nullable<decimal> Precio2 { get; set; }
        public Nullable<decimal> Precio3 { get; set; }
        public Nullable<decimal> Precio4 { get; set; }
        public Nullable<decimal> Min1 { get; set; }
        public Nullable<decimal> Min2 { get; set; }
        public Nullable<decimal> Min3 { get; set; }
        public Nullable<decimal> Min4 { get; set; }
    }
}
