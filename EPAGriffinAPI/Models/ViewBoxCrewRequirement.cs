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
    
    public partial class ViewBoxCrewRequirement
    {
        public Nullable<int> TypeId { get; set; }
        public int Id { get; set; }
        public int FlightPlanId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> CalanderId { get; set; }
        public int JobGroupId { get; set; }
        public int Min { get; set; }
        public Nullable<int> Assigned { get; set; }
    }
}
