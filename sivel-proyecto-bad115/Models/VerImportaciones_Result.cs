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
    
    public partial class VerImportaciones_Result
    {
        public int ID_IMPORTACION { get; set; }
        public int ID_UBICACION { get; set; }
        public int ID_EIMPORTACION { get; set; }
        public int ID_IMPORTADOR { get; set; }
        public int ID_VEHICULO { get; set; }
        public System.DateTime FECHA { get; set; }
        public string DESPERFECTO { get; set; }
        public Nullable<decimal> PRECIO_VENTA { get; set; }
    }
}
