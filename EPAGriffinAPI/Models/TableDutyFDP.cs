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
    
    public partial class TableDutyFDP
    {
        public System.DateTime CDate { get; set; }
        public Nullable<int> CrewId { get; set; }
        public Nullable<double> Duration { get; set; }
        public Nullable<double> DurationLocal { get; set; }
        public int FDPId { get; set; }
        public Nullable<System.DateTime> DutyStart { get; set; }
        public Nullable<System.DateTime> DutyEnd { get; set; }
        public Nullable<System.DateTime> DutyStartLocal { get; set; }
        public Nullable<System.DateTime> DutyEndLocal { get; set; }
        public Nullable<System.Guid> GUID { get; set; }
    }
}