namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FacturaItem
    {
        [Key]
        public int ItemID { get; set; }

        public decimal? Cantidad { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Subtotal { get; set; }

        [StringLength(50)]
        public string Codigo { get; set; }

        public int? FacturaID { get; set; }

        public int? ProductoID { get; set; }

        public decimal? CantAlmacen { get; set; }

        public bool? Eliminada { get; set; }

        public decimal? Costo { get; set; }

        public string Cotizacion { get; set; }

        [StringLength(100)]
        public string Expiraciones { get; set; }

        public decimal? Itbis { get; set; }

        public decimal? Monto { get; set; }

        public bool? Prepado { get; set; }

        public bool? SinImpuesto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fin { get; set; }

        public decimal? Precio1 { get; set; }

        public decimal? Precio2 { get; set; }

        public decimal? Precio3 { get; set; }

        public decimal? Precio4 { get; set; }

        public decimal? Min1 { get; set; }

        public decimal? Min2 { get; set; }

        public decimal? Min3 { get; set; }

        public decimal? Min4 { get; set; }
    }
}
