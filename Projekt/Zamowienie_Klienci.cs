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
    
    public partial class Zamowienie_Klienci
    {
        public int zamowienie_klient_id { get; set; }
        public int klient_id { get; set; }
        public int zamowienie_id { get; set; }
        public string stan_pracy { get; set; }
        public string stan_platnosci { get; set; }
    
        public virtual Klienci Klienci { get; set; }
        public virtual Stan_Platnosci Stan_Platnosci1 { get; set; }
        public virtual Stan_Pracy Stan_Pracy1 { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
