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
    
    public partial class detalleVenta
    {
        public int idDetalle { get; set; }
        public decimal numFactura { get; set; }
        public decimal idVenta { get; set; }
        public float subTotal { get; set; }
        public string idProducto { get; set; }
        public decimal descuento { get; set; }
        public int cantidad { get; set; }
    
        public virtual venta venta { get; set; }
        public virtual factura factura { get; set; }
        public virtual producto producto { get; set; }
    }
}
