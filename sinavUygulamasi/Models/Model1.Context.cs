﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sinavUygulamasi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sinavdbEntities1 : DbContext
    {
        public sinavdbEntities1()
            : base("name=sinavdbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hakkimizda> hakkimizdas { get; set; }
        public virtual DbSet<iletisim> iletisims { get; set; }
        public virtual DbSet<kategori> kategoris { get; set; }
        public virtual DbSet<ozellikler> ozelliklers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tarihce> tarihces { get; set; }
        public virtual DbSet<urunler> urunler { get; set; }
    }
}
