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
    public partial class tbl_Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Usuarios()
        {
            this.tbl_BiblioTK_Donativos = new HashSet<tbl_BiblioTK_Donativos>();
            this.tbl_BiblioTK_Log = new HashSet<tbl_BiblioTK_Log>();
            this.tbl_BiblioTK_Votacion = new HashSet<tbl_BiblioTK_Votacion>();
            this.tbl_Seguridad_Log = new HashSet<tbl_Seguridad_Log>();
            this.tbl_Seguridad_PWrecovery = new HashSet<tbl_Seguridad_PWrecovery>();
            this.tbl_BiblioTK_Catalogo = new HashSet<tbl_BiblioTK_Catalogo>();
        }
        [Key]
        public System.Guid usuario_uid { get; set; }
        public Nullable<byte> usuario_tipo { get; set; }
        public string usuario_apellido_paterno { get; set; }
        public string usuario_apellido_materno { get; set; }
        public string usuario_nombre { get; set; }
        public string usuario_sexo { get; set; }
        public System.DateTime usuario_nacimiento { get; set; }
        public string usuario_nacimiento_pais { get; set; }
        public byte[] usuario_foto { get; set; }
        public string usuario_foto_tipo { get; set; }
        public string usuario_email { get; set; }
        public string usuario_password { get; set; }
        public short usuario_status { get; set; }
        public System.DateTime usuario_fecha_registro { get; set; }
        public System.DateTime usuario_fecha_ping { get; set; }
        public string admin_cargo { get; set; }
    
        public virtual APP_GEO_Paises APP_GEO_Paises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BiblioTK_Donativos> tbl_BiblioTK_Donativos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BiblioTK_Log> tbl_BiblioTK_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BiblioTK_Votacion> tbl_BiblioTK_Votacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Seguridad_Log> tbl_Seguridad_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Seguridad_PWrecovery> tbl_Seguridad_PWrecovery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BiblioTK_Catalogo> tbl_BiblioTK_Catalogo { get; set; }
    }
}
