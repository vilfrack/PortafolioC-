﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace portafolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class portafolioEntities2 : DbContext
    {
        public portafolioEntities2()
            : base("name=portafolioEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<backend> backend { get; set; }
        public virtual DbSet<frontend> frontend { get; set; }
        public virtual DbSet<login> login { get; set; }
        public virtual DbSet<master_portafolio> master_portafolio { get; set; }
        public virtual DbSet<perfil> perfil { get; set; }
        public virtual DbSet<portafolio> portafolio { get; set; }
    }
}
