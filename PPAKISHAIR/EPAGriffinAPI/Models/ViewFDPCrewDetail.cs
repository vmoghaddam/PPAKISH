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
    
    public partial class ViewFDPCrewDetail
    {
        public Nullable<int> FDPId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public string Position { get; set; }
        public Nullable<int> PositionId { get; set; }
        public Nullable<int> RosterPositionId { get; set; }
        public string Mobile { get; set; }
        public string Route { get; set; }
        public string Flights { get; set; }
        public Nullable<System.DateTime> DaySTDLocal { get; set; }
        public Nullable<System.DateTime> DepartureLocal { get; set; }
        public Nullable<System.DateTime> ArrivalLocal { get; set; }
    }
}
