namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clientes")]
    public partial class Cliente1
    {
        [Key]
        public int ClienteID { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Representante { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        public string Correo { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Nota { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(15)]
        public string Rnc { get; set; }

        [StringLength(50)]
        public string Precio { get; set; }

        public string Fichas { get; set; }

        public decimal? Descuento { get; set; }

        public int? VendedorId { get; set; }

        public string Vendedor { get; set; }

        public int? LimiteCredito { get; set; }
    }
}
