//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPAGriffinAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightRegisterChangeLog
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int OldRegisterId { get; set; }
        public int NewRegisterId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> UserId { get; set; }
        public int ReasonId { get; set; }
        public string Remark { get; set; }
    }
}
