//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace portafolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class portafolio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public portafolio()
        {
            this.master_portafolio = new HashSet<master_portafolio>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
        public string ruta { get; set; }
        public string img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<master_portafolio> master_portafolio { get; set; }
    }
}