﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LegistOS.Classi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class user37_dbEntities : DbContext
    {
        public user37_dbEntities()
            : base("name=user37_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DIzdavOrgan> DIzdavOrgans { get; set; }
        public virtual DbSet<DNPA> DNPAs { get; set; }
        public virtual DbSet<DOrganUstarNazv> DOrganUstarNazvs { get; set; }
        public virtual DbSet<DPravovayaBaza> DPravovayaBazas { get; set; }
        public virtual DbSet<DRegion> DRegions { get; set; }
        public virtual DbSet<DRol> DRols { get; set; }
        public virtual DbSet<DStatu> DStatus { get; set; }
        public virtual DbSet<DVid> DVids { get; set; }
        public virtual DbSet<DDocument> DDocuments { get; set; }
        public virtual DbSet<DPolzovatel> DPolzovatels { get; set; }
        public virtual DbSet<DTeg> DTegs { get; set; }
        public virtual DbSet<DIzbrannoe> DIzbrannoes { get; set; }
    }
}
