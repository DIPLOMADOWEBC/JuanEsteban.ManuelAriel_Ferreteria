namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Moneda
    {
        public int MonedaId { get; set; }

        [StringLength(10)]
        public string Simbolo { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public bool? Eliminada { get; set; }
    }
}
