namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FamiliaProducto")]
    public partial class FamiliaProducto
    {
        [Key]
        public int FamiliaID { get; set; }

        public string Descripcion { get; set; }

        public string Nota { get; set; }

        public int? ProductoId { get; set; }

        public int? ProductoIdFamilia { get; set; }
    }
}
