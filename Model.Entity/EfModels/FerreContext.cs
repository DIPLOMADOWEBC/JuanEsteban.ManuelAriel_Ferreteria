namespace Model.Entity.EfModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FerreContext : DbContext
    {
        public FerreContext()
            : base("name=FerreContext")
        {
        }

        public virtual DbSet<categoria> categorias { get; set; }
        public virtual DbSet<CategoriasProducto> CategoriasProductos { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<Cliente1> Clientes1 { get; set; }
        public virtual DbSet<CompraItem> CompraItems { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Configuracion> Configuracions { get; set; }
        public virtual DbSet<CorreosCliente> CorreosClientes { get; set; }
        public virtual DbSet<detalleVenta> detalleVentas { get; set; }
        public virtual DbSet<factura> facturas { get; set; }
        public virtual DbSet<FacturaItem> FacturaItems { get; set; }
        public virtual DbSet<Factura1> Facturas1 { get; set; }
        public virtual DbSet<FamiliaProducto> FamiliaProductoes { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<modoPago> modoPagoes { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<NCF> NCFs { get; set; }
        public virtual DbSet<producto> productoes { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Sucursale> Sucursales { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<vendedor> vendedors { get; set; }
        public virtual DbSet<Vendedore> Vendedores { get; set; }
        public virtual DbSet<venta> ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<categoria>()
                .HasMany(e => e.productoes)
                .WithRequired(e => e.categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CategoriasProducto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CategoriasProducto>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.idCliente)
                .HasPrecision(18, 0);

            modelBuilder.Entity<cliente>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.apPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.apMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.dni)
                .HasPrecision(11, 0);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.ventas)
                .WithRequired(e => e.cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente1>()
                .Property(e => e.Fichas)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente1>()
                .Property(e => e.Vendedor)
                .IsUnicode(false);

            modelBuilder.Entity<CompraItem>()
                .Property(e => e.Expiraciones)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Rnc)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Ncf)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.TipoBienesServicios)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Ano)
                .IsUnicode(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Configuracion>()
                .Property(e => e.Telefono)
                .IsFixedLength();

            modelBuilder.Entity<Configuracion>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<Configuracion>()
                .Property(e => e.Rnc)
                .IsFixedLength();

            modelBuilder.Entity<detalleVenta>()
                .Property(e => e.numFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<detalleVenta>()
                .Property(e => e.idVenta)
                .HasPrecision(18, 0);

            modelBuilder.Entity<detalleVenta>()
                .Property(e => e.descuento)
                .HasPrecision(19, 4);

            modelBuilder.Entity<factura>()
                .Property(e => e.numFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<factura>()
                .Property(e => e.descuento)
                .HasPrecision(19, 4);

            modelBuilder.Entity<factura>()
                .HasMany(e => e.detalleVentas)
                .WithRequired(e => e.factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Expiraciones)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Precio1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Precio2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Precio3)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Precio4)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Min1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Min2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Min3)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaItem>()
                .Property(e => e.Min4)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Nota)
                .IsFixedLength();

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Prazo)
                .IsUnicode(false);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Rnc)
                .IsUnicode(false);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Ncf)
                .IsUnicode(false);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Vendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Cajero)
                .IsUnicode(false);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Factura1>()
                .Property(e => e.Tasa)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.CodigoFabricante)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio3)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio4)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Min1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Min2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Min3)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Min4)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio1_Itbis)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio2_Itbis)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio3_Itbis)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.Precio4_Itbis)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.EstadoDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<modoPago>()
                .HasMany(e => e.facturas)
                .WithRequired(e => e.modoPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Simbolo)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<producto>()
                .Property(e => e.precioUnitario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Representante)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Rnc)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Precio)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursale>()
                .Property(e => e.Fichas)
                .IsUnicode(false);

            modelBuilder.Entity<vendedor>()
                .HasMany(e => e.ventas)
                .WithRequired(e => e.vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedore>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<venta>()
                .Property(e => e.idVenta)
                .HasPrecision(18, 0);

            modelBuilder.Entity<venta>()
                .Property(e => e.idCliente)
                .HasPrecision(18, 0);

            modelBuilder.Entity<venta>()
                .Property(e => e.IVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<venta>()
                .HasMany(e => e.detalleVentas)
                .WithRequired(e => e.venta)
                .WillCascadeOnDelete(false);
        }
    }
}
