namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("producto")]
    public partial class producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProducto { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Column(TypeName = "money")]
        public decimal precioUnitario { get; set; }

        [Required]
        [StringLength(5)]
        public string idCategoria { get; set; }

        public virtual categoria categoria { get; set; }
    }
}
