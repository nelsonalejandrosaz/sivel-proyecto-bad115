//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sivel_proyecto_bad115
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMPORTADORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMPORTADORES()
        {
            this.IMPORTACIONES = new HashSet<IMPORTACIONES>();
        }
    
        public int ID_IMPORTADOR { get; set; }
        public int NIT { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string APELLIDO_CASADA { get; set; }
        public string GENERO { get; set; }
        public System.DateTime FECHA_NACIMIENTO { get; set; }
        public string DIRECCION { get; set; }
        public string PERSONA_RESPONSABLE { get; set; }
        public string TELEFONO_RESPONSABLE { get; set; }
        public string EMAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPORTACIONES> IMPORTACIONES { get; set; }
    }
}
