//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EIgnacioMarzamEntities : DbContext
    {
        public EIgnacioMarzamEntities()
            : base("name=EIgnacioMarzamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Medicamento> Medicamentoes { get; set; }
        public virtual DbSet<Pedido> Pedidoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual int MedicamentoAdd(string skun, string nombreMedicamento, Nullable<decimal> precioMedicamento, Nullable<int> cantidad, string imagen)
        {
            var skunParameter = skun != null ?
                new ObjectParameter("Skun", skun) :
                new ObjectParameter("Skun", typeof(string));
    
            var nombreMedicamentoParameter = nombreMedicamento != null ?
                new ObjectParameter("NombreMedicamento", nombreMedicamento) :
                new ObjectParameter("NombreMedicamento", typeof(string));
    
            var precioMedicamentoParameter = precioMedicamento.HasValue ?
                new ObjectParameter("PrecioMedicamento", precioMedicamento) :
                new ObjectParameter("PrecioMedicamento", typeof(decimal));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MedicamentoAdd", skunParameter, nombreMedicamentoParameter, precioMedicamentoParameter, cantidadParameter, imagenParameter);
        }
    
        public virtual ObjectResult<MedicamentoGetAll_Result> MedicamentoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MedicamentoGetAll_Result>("MedicamentoGetAll");
        }
    
        public virtual ObjectResult<MedicamentoGetById_Result> MedicamentoGetById(Nullable<int> idMedicamento)
        {
            var idMedicamentoParameter = idMedicamento.HasValue ?
                new ObjectParameter("IdMedicamento", idMedicamento) :
                new ObjectParameter("IdMedicamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MedicamentoGetById_Result>("MedicamentoGetById", idMedicamentoParameter);
        }
    
        public virtual int PedidoAdd(Nullable<int> idUsuario, Nullable<int> idMedicamento)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idMedicamentoParameter = idMedicamento.HasValue ?
                new ObjectParameter("IdMedicamento", idMedicamento) :
                new ObjectParameter("IdMedicamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PedidoAdd", idUsuarioParameter, idMedicamentoParameter);
        }
    
        public virtual ObjectResult<PedidoGetAll_Result> PedidoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PedidoGetAll_Result>("PedidoGetAll");
        }
    
        public virtual ObjectResult<PedidoGetById_Result> PedidoGetById(Nullable<int> idPedido)
        {
            var idPedidoParameter = idPedido.HasValue ?
                new ObjectParameter("IdPedido", idPedido) :
                new ObjectParameter("IdPedido", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PedidoGetById_Result>("PedidoGetById", idPedidoParameter);
        }
    
        public virtual int PedidoUpdate(Nullable<int> idPedido, Nullable<int> idUsuario, Nullable<int> idMedicamento, Nullable<decimal> precioPedido, Nullable<int> cantidadPedido)
        {
            var idPedidoParameter = idPedido.HasValue ?
                new ObjectParameter("IdPedido", idPedido) :
                new ObjectParameter("IdPedido", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idMedicamentoParameter = idMedicamento.HasValue ?
                new ObjectParameter("IdMedicamento", idMedicamento) :
                new ObjectParameter("IdMedicamento", typeof(int));
    
            var precioPedidoParameter = precioPedido.HasValue ?
                new ObjectParameter("PrecioPedido", precioPedido) :
                new ObjectParameter("PrecioPedido", typeof(decimal));
    
            var cantidadPedidoParameter = cantidadPedido.HasValue ?
                new ObjectParameter("CantidadPedido", cantidadPedido) :
                new ObjectParameter("CantidadPedido", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PedidoUpdate", idPedidoParameter, idUsuarioParameter, idMedicamentoParameter, precioPedidoParameter, cantidadPedidoParameter);
        }
    
        public virtual ObjectResult<UsuarioGetAll_Result> UsuarioGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetAll_Result>("UsuarioGetAll");
        }
    
        public virtual ObjectResult<UsuarioLogin_Result> UsuarioLogin(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioLogin_Result>("UsuarioLogin", nombreParameter);
        }
    
        public virtual int MedicamentoUpdate(Nullable<int> idMedicamento, string skun, string nombreMedicamento, Nullable<decimal> precioMedicamento, Nullable<int> cantidad, string imagen)
        {
            var idMedicamentoParameter = idMedicamento.HasValue ?
                new ObjectParameter("IdMedicamento", idMedicamento) :
                new ObjectParameter("IdMedicamento", typeof(int));
    
            var skunParameter = skun != null ?
                new ObjectParameter("Skun", skun) :
                new ObjectParameter("Skun", typeof(string));
    
            var nombreMedicamentoParameter = nombreMedicamento != null ?
                new ObjectParameter("NombreMedicamento", nombreMedicamento) :
                new ObjectParameter("NombreMedicamento", typeof(string));
    
            var precioMedicamentoParameter = precioMedicamento.HasValue ?
                new ObjectParameter("PrecioMedicamento", precioMedicamento) :
                new ObjectParameter("PrecioMedicamento", typeof(decimal));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MedicamentoUpdate", idMedicamentoParameter, skunParameter, nombreMedicamentoParameter, precioMedicamentoParameter, cantidadParameter, imagenParameter);
        }
    }
}
