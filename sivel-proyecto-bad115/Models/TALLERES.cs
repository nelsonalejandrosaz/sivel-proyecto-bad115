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
    
    public partial class TALLERES
    {
        public TALLERES()
        {
            this.MOVIMIENTOS = new HashSet<MOVIMIENTOS>();
        }
    
        public int ID_TALLER { get; set; }
        public string NOMBRE { get; set; }
    
        public virtual ICollection<MOVIMIENTOS> MOVIMIENTOS { get; set; }
    }
}