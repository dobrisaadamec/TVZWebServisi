﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Citus.Education.WebApp.Sample.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CvCompetence> CvCompetences { get; set; }
        public virtual DbSet<CvCompetencesGroup> CvCompetencesGroups { get; set; }
        public virtual DbSet<CvCompetencesRate> CvCompetencesRates { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
    }
}