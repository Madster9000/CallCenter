﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Support.Datasources.MsCrm
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MsCrmDataContext : DbContext
    {
        public MsCrmDataContext()
            : base("name=MsCrmDataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContactBase> ContactBase { get; set; }
        public virtual DbSet<ContactExtensionBase> ContactExtensionBase { get; set; }
    }
}
