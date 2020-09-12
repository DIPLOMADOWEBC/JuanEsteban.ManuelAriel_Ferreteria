namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Configuracion")]
    public partial class Configuracion
    {
        public int ConfiguracionID { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string Rnc { get; set; }

        public string Notas { get; set; }

        public decimal? Itbis { get; set; }

        [StringLength(50)]
        public string Representante { get; set; }

        public decimal? PorPre1 { get; set; }

        public decimal? PorPre2 { get; set; }

        public decimal? PorPre3 { get; set; }

        public bool? ImpuestoEnProducto { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Seguro { get; set; }

        public decimal? Transporte { get; set; }

        public bool? PermitirDescuento { get; set; }

        public int? PrinterPredeterminado { get; set; }
    }
}
