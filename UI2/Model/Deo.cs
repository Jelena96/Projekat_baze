//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Deo()
        {
            this.Porucujes = new HashSet<Porucuje>();
        }
    
        public string Naziv_deo { get; set; }
        public string Prozivodjac { get; set; }
        public int Sifra_Deo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Porucuje> Porucujes { get; set; }
    }
}
