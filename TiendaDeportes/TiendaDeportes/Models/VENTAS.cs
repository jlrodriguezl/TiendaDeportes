//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaDeportes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENTAS()
        {
            this.VENTA_PRODUCTOS = new HashSet<VENTA_PRODUCTOS>();
        }
    
        public int ID_VENTA { get; set; }
        public System.DateTime FECHA_VENTA { get; set; }
        public decimal VLR_IVA { get; set; }
        public decimal ID_PERSONA { get; set; }
        public string TIPO_PERSONA { get; set; }
    
        public virtual PERSONAS PERSONAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA_PRODUCTOS> VENTA_PRODUCTOS { get; set; }
    }
}
