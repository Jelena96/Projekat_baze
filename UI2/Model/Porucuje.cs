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
    
    public partial class Porucuje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Porucuje()
        {
            this.Dobavljacs = new HashSet<Dobavljac>();
            this.Pripadas = new HashSet<Pripada>();
        }
    
        public int Komercijalista_Sifra_radnika { get; set; }
        public int Deo_Sifra_Deo { get; set; }
    
        public virtual Deo Deo { get; set; }
        public virtual Komercijalista Komercijalista { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dobavljac> Dobavljacs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pripada> Pripadas { get; set; }
    }
}