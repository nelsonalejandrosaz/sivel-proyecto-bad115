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
    using System.ComponentModel.DataAnnotations;
    
    public partial class IMPORTACIONES
    {
        public IMPORTACIONES()
        {
            this.MOVIMIENTOS = new HashSet<MOVIMIENTOS>();
        }
    
        public int ID_IMPORTACION { get; set; }
        [Required]
        [Display(Name = "Ubicacion")]
        public int ID_UBICACION { get; set; }
        [Required]
        [Display(Name = "EstadoImportacion")]
        public int ID_EIMPORTACION { get; set; }
        [Required]
        [Display(Name = "Importador")]
        public int ID_IMPORTADOR { get; set; }
        [Required]
        [Display(Name = "Vehiculo")]
        public int ID_VEHICULO { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public System.DateTime FECHA { get; set; }
        [Required]
        [Display(Name = "Desperfecto")]
        public string DESPERFECTO { get; set; }
        [Display(Name = "Precio venta")]
        public Nullable<decimal> PRECIO_VENTA { get; set; }
    
        public virtual ESTADO_IMPORTACIONES ESTADO_IMPORTACIONES { get; set; }
        public virtual VEHICULOS VEHICULOS { get; set; }
        public virtual IMPORTADORES IMPORTADORES { get; set; }
        public virtual UBICACIONES UBICACIONES { get; set; }
        public virtual ICollection<MOVIMIENTOS> MOVIMIENTOS { get; set; }
    }
}
