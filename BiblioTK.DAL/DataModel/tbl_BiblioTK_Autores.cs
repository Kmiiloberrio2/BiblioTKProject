//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class tbl_BiblioTK_Autores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_BiblioTK_Autores()
        {
            this.tbl_BiblioTK_Catalogo_Autores = new HashSet<tbl_BiblioTK_Catalogo_Autores>();
        }
        [Key]
        public System.Guid autor_uid { get; set; }
        public string autor_cutter { get; set; }
        public string autor_nombre { get; set; }
        public string autor_apellido_paterno { get; set; }
        public string autor_apellido_materno { get; set; }
        public string autor_año_nacimiento { get; set; }
        public string autor_año_muerte { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BiblioTK_Catalogo_Autores> tbl_BiblioTK_Catalogo_Autores { get; set; }
    }
}
