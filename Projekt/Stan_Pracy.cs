//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stan_Pracy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stan_Pracy()
        {
            this.Zamowienie_Klienci = new HashSet<Zamowienie_Klienci>();
        }
    
        public string stan_pracy1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie_Klienci> Zamowienie_Klienci { get; set; }
    }
}
