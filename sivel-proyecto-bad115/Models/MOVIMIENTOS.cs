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
    
    public partial class MOVIMIENTOS
    {
        public int ID_MOVIMIENTO { get; set; }
        public Nullable<int> ID_TALLER { get; set; }
        public int ID_IMPORTACION { get; set; }
        public int ID_TMOVIMIENTO { get; set; }
        public Nullable<int> ID_TREMOLQUE { get; set; }
        public System.DateTime FECHA { get; set; }
    
        public virtual IMPORTACIONES IMPORTACIONES { get; set; }
        public virtual TIPO_MOVIMIENTOS TIPO_MOVIMIENTOS { get; set; }
        public virtual TIPO_REMOLQUES TIPO_REMOLQUES { get; set; }
        public virtual TALLERES TALLERES { get; set; }
    }
}