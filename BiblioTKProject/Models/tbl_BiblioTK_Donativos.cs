//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioTKProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_BiblioTK_Donativos
    {
        public System.Guid donativo_uid { get; set; }
        public System.Guid usuario_uid { get; set; }
        public double donativo_importe { get; set; }
        public System.DateTime donativo_fecha { get; set; }
    
        public virtual tbl_Usuarios tbl_Usuarios { get; set; }
    }
}
