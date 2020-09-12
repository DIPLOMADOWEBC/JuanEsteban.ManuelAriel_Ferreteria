namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventario")]
    public partial class Inventario
    {
        [Key]
        public int idProducto { get; set; }

        [StringLength(50)]
        public string CodigoFabricante { get; set; }

        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public decimal? Costo { get; set; }

        public decimal? Precio1 { get; set; }

        public decimal? Precio2 { get; set; }

        public decimal? Precio3 { get; set; }

        public decimal? Precio4 { get; set; }

        public decimal? Stock { get; set; }

        [StringLength(200)]
        public string Nota { get; set; }

        public int? ProveedorID { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(100)]
        public string Proveedor { get; set; }

        public decimal? PorPre1 { get; set; }

        public decimal? PorPre2 { get; set; }

        public decimal? PorPre3 { get; set; }

        public decimal? PorPre4 { get; set; }

        public decimal? Minimo { get; set; }

        public int? CategoriaID { get; set; }

        [StringLength(100)]
        public string Categoria { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaExpedicion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaExpiracion { get; set; }

        public int? FamiliaID { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        public bool? SinImpuesto { get; set; }

        public int? EstadoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Desde { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Hasta { get; set; }

        public bool? Activo { get; set; }

        public decimal? Min1 { get; set; }

        public decimal? Min2 { get; set; }

        public decimal? Min3 { get; set; }

        public decimal? Min4 { get; set; }

        public decimal? Precio1_Itbis { get; set; }

        public decimal? Precio2_Itbis { get; set; }

        public decimal? Precio3_Itbis { get; set; }

        public decimal? Precio4_Itbis { get; set; }

        public int? IdEstadoArticulo { get; set; }

        [StringLength(100)]
        public string EstadoDescripcion { get; set; }
    }
}
