﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioTK.DAL.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CygnusBiblioTKv2Entities : DbContext
    {
        public CygnusBiblioTKv2Entities()
            : base("name=CygnusBiblioTKv2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<APP_GEO_Paises> APP_GEO_Paises { get; set; }
        public virtual DbSet<tbl_BiblioTK_Autores> tbl_BiblioTK_Autores { get; set; }
        public virtual DbSet<tbl_BiblioTK_Catalogo_Autores> tbl_BiblioTK_Catalogo_Autores { get; set; }
        public virtual DbSet<tbl_BiblioTK_Catalogo_Temas> tbl_BiblioTK_Catalogo_Temas { get; set; }
        public virtual DbSet<tbl_BiblioTK_class1> tbl_BiblioTK_class1 { get; set; }
        public virtual DbSet<tbl_BiblioTK_class2> tbl_BiblioTK_class2 { get; set; }
        public virtual DbSet<tbl_BiblioTK_class3> tbl_BiblioTK_class3 { get; set; }
        public virtual DbSet<tbl_BiblioTK_class4> tbl_BiblioTK_class4 { get; set; }
        public virtual DbSet<tbl_BiblioTK_Donativos> tbl_BiblioTK_Donativos { get; set; }
        public virtual DbSet<tbl_BiblioTK_Editoriales> tbl_BiblioTK_Editoriales { get; set; }
        public virtual DbSet<tbl_BiblioTK_Idiomas> tbl_BiblioTK_Idiomas { get; set; }
        public virtual DbSet<tbl_BiblioTK_Log> tbl_BiblioTK_Log { get; set; }
        public virtual DbSet<tbl_BiblioTK_Temas> tbl_BiblioTK_Temas { get; set; }
        public virtual DbSet<tbl_BiblioTK_Votacion> tbl_BiblioTK_Votacion { get; set; }
        public virtual DbSet<tbl_Plantel> tbl_Plantel { get; set; }
        public virtual DbSet<tbl_Seguridad_Log> tbl_Seguridad_Log { get; set; }
        public virtual DbSet<tbl_Seguridad_PWrecovery> tbl_Seguridad_PWrecovery { get; set; }
        public virtual DbSet<tbl_Usuarios> tbl_Usuarios { get; set; }
        public virtual DbSet<tbl_BiblioTK_Catalogo> tbl_BiblioTK_Catalogo { get; set; }
    }
}
