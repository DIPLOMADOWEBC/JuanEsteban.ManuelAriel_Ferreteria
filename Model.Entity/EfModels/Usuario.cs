namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuario
    {
        public int UsuarioID { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Contrasena { get; set; }

        [StringLength(50)]
        public string Facturacion { get; set; }

        [StringLength(50)]
        public string Compras { get; set; }

        [StringLength(50)]
        public string CuentasPorPagar { get; set; }

        [StringLength(50)]
        public string CuentasPorCobrar { get; set; }

        [StringLength(50)]
        public string Usuarios { get; set; }

        [StringLength(50)]
        public string Inventario { get; set; }

        [StringLength(50)]
        public string Clientes { get; set; }

        [StringLength(50)]
        public string Cajas { get; set; }

        [StringLength(50)]
        public string Conduce { get; set; }

        [StringLength(50)]
        public string Cotizacion { get; set; }

        [StringLength(50)]
        public string Contabilidad { get; set; }

        [StringLength(50)]
        public string NotaDeCredito { get; set; }

        [StringLength(50)]
        public string NotaDeDebito { get; set; }

        [StringLength(50)]
        public string Configuracion { get; set; }

        [StringLength(50)]
        public string Tasas { get; set; }
    }
}
