//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Dao.EntityContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class CorreosCliente
    {
        public int CorreoClienteId { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public Nullable<bool> Enviar { get; set; }
        public Nullable<int> ClienteId { get; set; }
    }
}
