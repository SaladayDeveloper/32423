﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class labEntities : DbContext
    {
        public labEntities()
            : base("name=labEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<analyzator> analyzator { get; set; }
        public virtual DbSet<blood> blood { get; set; }
        public virtual DbSet<blood_service> blood_service { get; set; }
        public virtual DbSet<buhgalter> buhgalter { get; set; }
        public virtual DbSet<company_of_buh> company_of_buh { get; set; }
        public virtual DbSet<data_pacient> data_pacient { get; set; }
        public virtual DbSet<laborant> laborant { get; set; }
        public virtual DbSet<service> service { get; set; }
        public virtual DbSet<service_bugh> service_bugh { get; set; }
        public virtual DbSet<services_of_lab> services_of_lab { get; set; }
        public virtual DbSet<story_input> story_input { get; set; }
        public virtual DbSet<strah_company> strah_company { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
