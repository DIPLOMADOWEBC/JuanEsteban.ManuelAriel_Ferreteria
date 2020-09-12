namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CompraItem
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

        public int? CompraID { get; set; }

        public int? ProductoID { get; set; }

        public decimal? CantAlmacen { get; set; }

        public bool? Eliminada { get; set; }

        public string Expiraciones { get; set; }
    }
}
