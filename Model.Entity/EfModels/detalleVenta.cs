namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("detalleVenta")]
    public partial class detalleVenta
    {
        [Key]
        [Column(Order = 0)]
        public int idDetalle { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal numFactura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal idVenta { get; set; }

        public float subTotal { get; set; }

        public int idProducto { get; set; }

        [Column(TypeName = "money")]
        public decimal descuento { get; set; }

        public int cantidad { get; set; }

        public virtual venta venta { get; set; }

        public virtual factura factura { get; set; }
    }
}
