namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCF")]
    public partial class NCF
    {
        [Key]
        public int ComprobanteID { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string NcfFijos { get; set; }

        [StringLength(8)]
        public string NcfDinamicos { get; set; }

        public int? ddsf { get; set; }

        public int? Cantidad { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expiracion { get; set; }

        public int? Consumidos { get; set; }

        public int? CantidadNotifica { get; set; }
    }
}
