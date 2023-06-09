﻿//------------------------------------------------------------------------------
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
    
    public partial class UEstebanGReformaEntities : DbContext
    {
        public UEstebanGReformaEntities()
            : base("name=UEstebanGReformaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Persona> Personas { get; set; }
    
        public virtual int PersonaCRUD(string action, Nullable<int> idPersona, string nombre, string direccion, Nullable<int> edad, string correo, string habilidad1, string habilidad2, Nullable<int> idTipo)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var idPersonaParameter = idPersona.HasValue ?
                new ObjectParameter("IdPersona", idPersona) :
                new ObjectParameter("IdPersona", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("Edad", edad) :
                new ObjectParameter("Edad", typeof(int));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var habilidad1Parameter = habilidad1 != null ?
                new ObjectParameter("Habilidad1", habilidad1) :
                new ObjectParameter("Habilidad1", typeof(string));
    
            var habilidad2Parameter = habilidad2 != null ?
                new ObjectParameter("habilidad2", habilidad2) :
                new ObjectParameter("habilidad2", typeof(string));
    
            var idTipoParameter = idTipo.HasValue ?
                new ObjectParameter("IdTipo", idTipo) :
                new ObjectParameter("IdTipo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PersonaCRUD", actionParameter, idPersonaParameter, nombreParameter, direccionParameter, edadParameter, correoParameter, habilidad1Parameter, habilidad2Parameter, idTipoParameter);
        }
    
        public virtual ObjectResult<PersonaGetAll_Result> PersonaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PersonaGetAll_Result>("PersonaGetAll");
        }
    
        public virtual ObjectResult<PersonaGetById_Result> PersonaGetById(Nullable<int> idPersona)
        {
            var idPersonaParameter = idPersona.HasValue ?
                new ObjectParameter("IdPersona", idPersona) :
                new ObjectParameter("IdPersona", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PersonaGetById_Result>("PersonaGetById", idPersonaParameter);
        }
    }
}
