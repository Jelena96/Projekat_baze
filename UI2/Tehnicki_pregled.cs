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
    
    public partial class Tehnicki_pregled
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tehnicki_pregled()
        {
            this.Radnik_na_tehnickom_pregledu = new HashSet<Radnik_na_tehnickom_pregledu>();
        }
    
        public int Sifra_usluge { get; set; }
        public string Uspesnost { get; set; }
    
        public virtual Usluga Usluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Radnik_na_tehnickom_pregledu> Radnik_na_tehnickom_pregledu { get; set; }
    }
}
