//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Radnik_na_tehnickom_pregledu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Radnik_na_tehnickom_pregledu()
        {
            this.Autoes = new HashSet<Auto>();
            this.Tehnicki_pregled = new HashSet<Tehnicki_pregled>();
        }
    
        public string Vrsta_vozila { get; set; }
        public int Sifra_radnika { get; set; }
    
        public virtual Radnik Radnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auto> Autoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tehnicki_pregled> Tehnicki_pregled { get; set; }
    }
}
