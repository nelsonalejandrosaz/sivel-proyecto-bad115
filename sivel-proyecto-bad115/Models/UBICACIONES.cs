//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sivel_proyecto_bad115.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UBICACIONES
    {
        public UBICACIONES()
        {
            this.IMPORTACIONES = new HashSet<IMPORTACIONES>();
        }
    
        public int ID_UBICACION { get; set; }
        public int ID_BODEGA { get; set; }
        public Nullable<int> NIVEL { get; set; }
        public Nullable<int> NUMERO_PARQUEO { get; set; }
    
        public virtual BODEGAS BODEGAS { get; set; }
        public virtual ICollection<IMPORTACIONES> IMPORTACIONES { get; set; }
    }
}
