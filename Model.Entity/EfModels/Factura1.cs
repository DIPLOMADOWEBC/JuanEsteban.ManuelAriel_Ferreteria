namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Facturas")]
    public partial class Factura1
    {
        [Key]
        public int FacturaID { get; set; }

        public DateTime? Fecha { get; set; }

        public int? ClienteID { get; set; }

        public int? VehiculoID { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Itbis { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? Total { get; set; }

        [StringLength(100)]
        public string Nota { get; set; }

        [StringLength(50)]
        public string Prazo { get; set; }

        [StringLength(50)]
        public string Rnc { get; set; }

        [StringLength(50)]
        public string Ncf { get; set; }

        [StringLength(20)]
        public string TipoComprobante { get; set; }

        [StringLength(50)]
        public string Cliente { get; set; }

        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Marca { get; set; }

        [StringLength(20)]
        public string Modelo { get; set; }

        [StringLength(10)]
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

        public decimal? UtilidadBruta { get; set; }

        public decimal? UtilidadNeta { get; set; }

        public decimal? Costo { get; set; }

        [StringLength(50)]
        public string CorreoElectronico { get; set; }

        public int? VendedorID { get; set; }

        public string Vendedor { get; set; }

        public int? CajaID { get; set; }

        [StringLength(100)]
        public string Cajero { get; set; }

        public int? ReporteDeCajaID { get; set; }

        public decimal? Recibo { get; set; }

        public decimal? Cambio { get; set; }

        public bool? AfectarInventario { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public decimal? Seguro { get; set; }

        public decimal? PorcientoSeguro { get; set; }

        public int? MonedaId { get; set; }

        public decimal? Tasa { get; set; }

        public DateTime? FechaTasa { get; set; }
    }
}
