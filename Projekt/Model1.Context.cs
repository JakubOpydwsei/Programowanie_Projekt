﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Projekt_POEntities : DbContext
    {
        public Projekt_POEntities()
            : base("name=Projekt_POEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Stan_Platnosci> Stan_Platnosci { get; set; }
        public virtual DbSet<Stan_Pracy> Stan_Pracy { get; set; }
        public virtual DbSet<Zamowienie> Zamowienies { get; set; }
        public virtual DbSet<Zamowienie_Klienci> Zamowienie_Klienci { get; set; }
    }
}
