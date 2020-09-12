namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedore
    {
        [Key]
        public int ProveedorID { get; set; }

        [StringLength(200)]
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

        public bool? EsProveedor { get; set; }

        [StringLength(100)]
        public string NombreComercial { get; set; }

        public bool? Eliminado { get; set; }
    }
}
