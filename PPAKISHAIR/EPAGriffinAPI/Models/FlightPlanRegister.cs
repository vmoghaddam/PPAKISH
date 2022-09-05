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
    
    public partial class FlightPlanRegister
    {
        public int Id { get; set; }
        public int FlightPlanId { get; set; }
        public int PlannedRegisterId { get; set; }
        public int RegisterId { get; set; }
        public System.DateTime DateFrom { get; set; }
        public System.DateTime DateTo { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<System.DateTime> DateApproved { get; set; }
        public Nullable<int> ApproverId { get; set; }
        public Nullable<int> CalendarId { get; set; }
    
        public virtual FlightPlan FlightPlan { get; set; }
        public virtual Ac_MSN Ac_MSN { get; set; }
        public virtual Ac_MSN Ac_MSN1 { get; set; }
    }
}
