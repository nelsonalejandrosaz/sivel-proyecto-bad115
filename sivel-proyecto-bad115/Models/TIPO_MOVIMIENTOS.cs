//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sivel_proyecto_bad115.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_MOVIMIENTOS
    {
        public TIPO_MOVIMIENTOS()
        {
            this.MOVIMIENTOS = new HashSet<MOVIMIENTOS>();
        }
    
        public int ID_TMOVIMIENTO { get; set; }
        public string TIPO_MOVIMIENTO { get; set; }
    
        public virtual ICollection<MOVIMIENTOS> MOVIMIENTOS { get; set; }
    }
}
