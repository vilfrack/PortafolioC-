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
    
    public partial class master_portafolio
    {
        public int id { get; set; }
        public Nullable<int> id_portafolio { get; set; }
        public Nullable<int> id_backend { get; set; }
        public Nullable<int> id_fronend { get; set; }
    
        public virtual backend backend { get; set; }
        public virtual frontend frontend { get; set; }
        public virtual portafolio portafolio { get; set; }
    }
}