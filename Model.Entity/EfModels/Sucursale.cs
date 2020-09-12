namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sucursale
    {
        [Key]
        public int SucursarID { get; set; }

        public string Descripcion { get; set; }

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

        [StringLength(100)]
        public string Precio { get; set; }

        [StringLength(100)]
        public string Fichas { get; set; }
    }
}
