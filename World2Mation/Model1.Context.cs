﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace World2Mation
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public partial class World2MationEntities : DbContext
    {
        public World2MationEntities()
            : base("name=World2MationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> User { get; set; }

        [Display(Name="Admin Portal")]
        public virtual DbSet<Admin> Admin { get; set; }

        [DisplayName("Admin Portal")]
        public System.Data.Entity.DbSet<World2Mation.Models.AdminPortal> AdminPortals { get; set; }

        public System.Data.Entity.DbSet<World2Mation.Models.SecurityCentre> SecurityCentres { get; set; }
    }
}
