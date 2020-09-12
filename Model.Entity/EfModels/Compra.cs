namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Compra
    {
        public int CompraID { get; set; }

        public DateTime? Fecha { get; set; }

        public int? ClienteID { get; set; }

        public int? VehiculoID { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Itbis { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? Total { get; set; }

        [StringLength(500)]
        public string Nota { get; set; }

        [StringLength(20)]
        public string Prazo { get; set; }

        [StringLength(50)]
        public string Rnc { get; set; }

        [StringLength(50)]
        public string Ncf { get; set; }

        [StringLength(500)]
        public string TipoBienesServicios { get; set; }

        [StringLength(100)]
        public string Cliente { get; set; }

        [StringLength(1000)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Marca { get; set; }

        [StringLength(50)]
        public string Modelo { get; set; }

        [StringLength(50)]
        public string Ano { get; set; }

        [StringLength(20)]
        public string Ficha { get; set; }

        [StringLength(10)]
        public string Placa { get; set; }

        public DateTime? FechaVence { get; set; }

        public decimal? PorItbis { get; set; }

        public decimal? PorDes { get; set; }

        public bool? Eliminada { get; set; }

        public decimal? Pagado { get; set; }

        public decimal? Balance { get; set; }

        public int? Enumeracion { get; set; }

        [StringLength(150)]
        public string Correo { get; set; }
    }
}
