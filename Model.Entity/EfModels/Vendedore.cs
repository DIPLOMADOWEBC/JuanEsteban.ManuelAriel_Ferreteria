namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendedore
    {
        [Key]
        public int VendedorID { get; set; }

        public string Descripcion { get; set; }

        public decimal? Comision { get; set; }
    }
}
