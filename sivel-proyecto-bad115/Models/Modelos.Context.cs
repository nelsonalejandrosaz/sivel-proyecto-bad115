﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sivel_proyecto_bad115.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bad115Entidades : DbContext
    {
        public bad115Entidades()
            : base("name=bad115Entidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BODEGAS> BODEGAS { get; set; }
        public virtual DbSet<ESTADO_IMPORTACIONES> ESTADO_IMPORTACIONES { get; set; }
        public virtual DbSet<IMPORTACIONES> IMPORTACIONES { get; set; }
        public virtual DbSet<IMPORTADORES> IMPORTADORES { get; set; }
        public virtual DbSet<MOVIMIENTOS> MOVIMIENTOS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<TALLERES> TALLERES { get; set; }
        public virtual DbSet<TIPO_MOVIMIENTOS> TIPO_MOVIMIENTOS { get; set; }
        public virtual DbSet<TIPO_REMOLQUES> TIPO_REMOLQUES { get; set; }
        public virtual DbSet<UBICACIONES> UBICACIONES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VEHICULOS> VEHICULOS { get; set; }
    }
}
