namespace Model.Entity.EfModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CorreosCliente")]
    public partial class CorreosCliente
    {
        [Key]
        public int CorreoClienteId { get; set; }

        public string Descripcion { get; set; }

        public string Correo { get; set; }

        public bool? Enviar { get; set; }

        public int? ClienteId { get; set; }
    }
}
