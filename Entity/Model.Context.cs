﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace isTakipProje.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbIsTakipEntities : DbContext
    {
        public DbIsTakipEntities()
            : base("name=DbIsTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<TaskDetail> TaskDetail { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
    }
}
