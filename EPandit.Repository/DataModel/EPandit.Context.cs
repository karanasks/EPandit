﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPandit.Repository.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EPanditEntities : DbContext
    {
        public EPanditEntities()
            : base("name=EPanditEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MeasurementUnitMaster> MeasurementUnitMasters { get; set; }
        public virtual DbSet<PanditDetail> PanditDetails { get; set; }
        public virtual DbSet<PanditPoojaMapping> PanditPoojaMappings { get; set; }
        public virtual DbSet<PoojaMaster> PoojaMasters { get; set; }
        public virtual DbSet<PoojaSamagriMapping> PoojaSamagriMappings { get; set; }
        public virtual DbSet<SamagriMaster> SamagriMasters { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    }
}
