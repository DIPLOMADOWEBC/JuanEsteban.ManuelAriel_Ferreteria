//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFacturaMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventario
    {
        public string CodigoFabricante { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> Precio1 { get; set; }
        public Nullable<decimal> Precio2 { get; set; }
        public Nullable<decimal> Precio3 { get; set; }
        public Nullable<decimal> Precio4 { get; set; }
        public Nullable<decimal> Stock { get; set; }
        public string Nota { get; set; }
        public Nullable<int> ProveedorID { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Proveedor { get; set; }
        public Nullable<decimal> PorPre1 { get; set; }
        public Nullable<decimal> PorPre2 { get; set; }
        public Nullable<decimal> PorPre3 { get; set; }
        public Nullable<decimal> PorPre4 { get; set; }
        public Nullable<decimal> Minimo { get; set; }
        public Nullable<int> CategoriaID { get; set; }
        public string Categoria { get; set; }
        public Nullable<System.DateTime> FechaExpedicion { get; set; }
        public Nullable<System.DateTime> FechaExpiracion { get; set; }
        public Nullable<int> FamiliaID { get; set; }
        public string Tipo { get; set; }
        public Nullable<bool> SinImpuesto { get; set; }
        public Nullable<int> EstadoId { get; set; }
        public Nullable<System.DateTime> Desde { get; set; }
        public Nullable<System.DateTime> Hasta { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<decimal> Min1 { get; set; }
        public Nullable<decimal> Min2 { get; set; }
        public Nullable<decimal> Min3 { get; set; }
        public Nullable<decimal> Min4 { get; set; }
        public Nullable<decimal> Precio1_Itbis { get; set; }
        public Nullable<decimal> Precio2_Itbis { get; set; }
        public Nullable<decimal> Precio3_Itbis { get; set; }
        public Nullable<decimal> Precio4_Itbis { get; set; }
        public Nullable<int> IdEstadoArticulo { get; set; }
        public string EstadoDescripcion { get; set; }
        public int idProducto { get; set; }
    }
}
