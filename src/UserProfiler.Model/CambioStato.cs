//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserProfiler.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CambioStato
    {
        public int Id { get; set; }
        public System.DateTime Creazione { get; set; }
        public StatoTicket Stato { get; set; }
    
        public virtual Operatore Operatore { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}