namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoriasProductos")]
    public partial class CategoriasProducto
    {
        [Key]
        public int CategoriaID { get; set; }

        public string Descripcion { get; set; }

        public string Detalle { get; set; }
    }
}
